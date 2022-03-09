using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public class DrugWinAppBackendDto : BaseWinAppDto
    {
        public string DrugName { get; set; }
        public string Details { get; set; }
        public string Notes { get; set; }
        public string Meal { get; set; }
        public int StartFrequency { get; set; }
        public int EndFrequency { get; set; }
        public int DurartionMonth { get; set; }
        public int DurartionDay { get; set; }
        public string PrescriptionId { get; set; }
    }
    public class BaseWinAppDto
    {
        public string Id { get; set; }
        public long LocalId { get; set; }
    }

    public class ResponseNote
    {
        public long Id { get; set; }
        public string Note { get; set; }
        public long PrescriptionId { get; set; }
        public DateTime? PrescriptionDate { get; set; }
        public string PatientFullName { get; set; }
        public DoctorInfoDto DoctorInfo { get; set; }
    }

    public class ResponsePrescriptionServiceResultReport
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Result { get; set; }
        public string Result2 { get; set; }
        public string Title { get; set; }
    }
}
