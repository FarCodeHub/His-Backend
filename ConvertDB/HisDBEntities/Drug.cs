using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class Drug
    {
        public Drug()
        {
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
        }

        public int Id { get; set; }
        public int? GenericId { get; set; }
        public string BrandTitle { get; set; }
        public string LocalCode { get; set; }
        public decimal? Price { get; set; }
        public int? DrugCode { get; set; }
        public int? HisCode { get; set; }
        public int? CompanyId { get; set; }
        public int? StoregConditonId { get; set; }
        public int? DrugFormId { get; set; }
        public int? UnitId { get; set; }
        public int? BrokenConsumptionId { get; set; }
        public int? BrokenConsumptionBase { get; set; }
        public string ContentsOf { get; set; }
        public int? StopConsumptionDay { get; set; }
        public bool? IsHighRisk { get; set; }
        public bool? IsNarcotic { get; set; }
        public bool? IsSaleWithoutPrescription { get; set; }
        public bool? IsOtcRight { get; set; }
        public bool? IsTechnicalRight { get; set; }
        public string Note { get; set; }
        public int? LocalId { get; set; }

        public virtual Company Company { get; set; }
        public virtual DrugForm DrugForm { get; set; }
        public virtual GenericDrug Generic { get; set; }
        public virtual BaseValue StoregConditon { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
    }
}
