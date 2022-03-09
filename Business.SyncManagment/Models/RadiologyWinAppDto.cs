using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public class RadiologyWinAppDto : BaseWinAppDto
    {
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Report { get; set; }
    }
}
