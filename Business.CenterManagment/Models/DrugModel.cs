using AutoMapper;
using Business.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
    public class DrugModel : IModel
    {
        public string BrandTitle { get; set; }
        public int? Quantity { get; set; }
        public string Code { get; set; }
        public long? Id { get;   set; }
        public string Note { get; set; }
        public DrugDetailsModel DrugDetails { get; set; }

        public void CreateMap(Profile profile)
        {
            
        }

        public void Init()
        {
 
        }
    }
}
