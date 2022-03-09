using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public class DrugWinAppDto : BaseWinAppDto
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public string Notes { get; set; }
        public string Meal { get; set; }
        public int StartFrequency { get; set; }
        public int EndFrequency { get; set; }
        public int DurartionMonth { get; set; }
        public int DurartionDay { get; set; }
        public string PrescriptionId { get; set; }
    }
}
