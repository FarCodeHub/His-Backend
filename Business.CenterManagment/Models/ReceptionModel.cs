using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
   public class ReceptionModel
    {

    
        public string FullName { get; set; }
        public long Id { get;  set; }
        public int? ParentId { get;  set; }
        public string ServiceTypeTitle { get;  set; }
        public int ServiceTypeId { get;  set; }
        public int CenterId { get;  set; }
        public string MedicalCenterTitle { get;  set; }
        public int? PatientId { get;  set; }
        public DateTime? CreateTime { get;  set; }
        public DateTime? RefferDate { get;  set; }
        public string Note { get;  set; }
        public string ResultNote { get;  set; }
        public string CenterTitle { get;   set; }
        public List<PrescriptionModel> Prescriptions { get; set; }

    }
}
