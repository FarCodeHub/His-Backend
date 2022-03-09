using Business.SMSManagment.Models;
using DataAccess.Repositories.His;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Extensions
{
    public class SmsCenterValidation : AbstractValidator<MessageDto>
    {

        public SmsCenterValidation(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            RuleFor(d => d.CenterId).NotEmpty()
               .WithMessage(sharedLocalizer["BuyMessage.FieldValidation.Required.CenterId"]);//+

            RuleFor(d => d.Cost).NotEmpty()
              .WithMessage(sharedLocalizer["BuyMessage.FieldValidation.Required.Cost"]);//+
        }

    }
}
