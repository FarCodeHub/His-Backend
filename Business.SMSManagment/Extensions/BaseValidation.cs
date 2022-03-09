using Business.SMSManagment.Models;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Extensions
{
    public class BaseValidation : AbstractValidator<BaseDto>
    {
        public BaseValidation(IStringLocalizer sharedLocalizer)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(sharedLocalizer["GlobalForm.FieldValidation.Title"]);//+
            //RuleFor(x => x.TitleLang2).NotEmpty().WithMessage(sharedLocalizer["GlobalForm.FieldValidation.TitleLang2"]);//+
        }
    }
}
