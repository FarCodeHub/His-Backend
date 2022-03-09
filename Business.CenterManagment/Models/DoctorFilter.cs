﻿using Business.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
   public class DoctorFilter
    {
        public List<BaseValueModel> Sex { get; set; }
        public List<BaseValueModel> Experties { get; set; }
        public List<BaseValueModel> WorkingTime { get; set; }
        public string FullName { get; set; }

    }
}
