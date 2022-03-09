using AutoMapper;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
    public class BaseValueTypeModel :  IModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string UniqueName { get; set; }
        public string GroupName { get; set; }
        public bool IsReadOnly { get; set; }
        public string SubSystem { get; set; }
        public List<BaseValueModel> BaseValues { get; set; }

        public void CreateMap(Profile profile)
        {
            profile.CreateMap<BaseValueTypeModel, BaseValueType>();
            profile.CreateMap<BaseValueType, BaseValueTypeModel>();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
