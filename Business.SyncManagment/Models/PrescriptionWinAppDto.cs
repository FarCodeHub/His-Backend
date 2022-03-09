using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public class PrescriptionWinAppDto : BaseWinAppDto
    {
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public string Pharmacy { get; set; }
        public string Barcode { get; set; }
    }
}
