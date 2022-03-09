﻿using Business.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
   public class PharmacyFilter
    {
 
        public List<BaseValueModel> WorkingTime { get; set; }
        public string Title { get; set; }
        public bool? IsHomeDelivery { get; set; }

    }
}
