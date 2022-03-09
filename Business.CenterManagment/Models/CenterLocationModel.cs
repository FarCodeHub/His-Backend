using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
   public class CenterLocationModel:CenterLocation
    {
        public string CountryName { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string ZoneName { get; set; }

    }
}
