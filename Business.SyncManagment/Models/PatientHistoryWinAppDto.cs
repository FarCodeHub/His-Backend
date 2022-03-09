using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public class PatientHistoryWinAppDto : BaseWinAppDto
    {
        public string PatientId { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string DoctorId { get; set; }
        public string CC { get; set; }
        public string PHI { get; set; }
        public string PMH { get; set; }
        public string PSH { get; set; }
        public string POM { get; set; }
        public string II { get; set; }
        public string RR { get; set; }
        public string PR { get; set; }
        public string CancerStage { get; set; }
        public string CancerType { get; set; }
    }
}
