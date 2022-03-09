using AutoMapper;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
    public class BaseValueModel : BaseValue, IModel
    {
        public void CreateMap(Profile profile)
        {
            profile.CreateMap<BaseValueModel, BaseValue>();
            profile.CreateMap<BaseValue, BaseValueModel>();
        }

        public void Init()
        {
             
        }
    }
}
