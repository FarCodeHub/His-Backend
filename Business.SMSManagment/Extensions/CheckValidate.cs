using Business.SMSManagment.Models;
using FluentValidation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.SMSManagment.Extensions
{
    public class CheckValidate
    {
        public static BaseResponseDto Valid<T>(IValidator av, T t)
        {
            var resultValid = av.Validate(new ValidationContext<object>(t));

            if (!resultValid.IsValid)
            {
                var errors = resultValid.Errors
                    .GroupBy(f => f.PropertyName)
                    .Select(g => new ErrorDto
                    {
                        //PropertyName = g.Key,
                        PropertyName = Char.ToLowerInvariant(g.Key[0]) + g.Key.Substring(1),
                        Errors = resultValid.Errors.Where(p => p.PropertyName == g.Key).ToDictionary(d => d.ErrorCode, f => f.ErrorMessage)

                    })
                    .ToDictionary(x => x.PropertyName, x => x.Errors);

                return new BaseResponseDto
                {
                    Status = ResponseStatus.NotValid,
                    Message = "Dto Not Valid",
                    Errors = JsonConvert.SerializeObject(errors)
                };
            }
            else
            {
                return new BaseResponseDto
                {
                    Status = ResponseStatus.Success,
                };
            }
        }
    }


    public class ErrorDto
    {
        public string PropertyName { get; set; }
        public Dictionary<string, string> Errors { get; set; }
    }

}