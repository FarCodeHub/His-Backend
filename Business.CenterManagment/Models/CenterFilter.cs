using Business.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
   public class CenterFilter
    {
        public List<BaseValueModel> OwnerShips { get; set; }
        public string Title { get; set; }

    }
}
