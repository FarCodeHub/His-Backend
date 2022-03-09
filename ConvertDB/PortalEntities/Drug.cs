using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Drug
    {
        public Drug()
        {
            DrugStoregConditions = new HashSet<DrugStoregCondition>();
            InteractionFirstDrugs = new HashSet<Interaction>();
            InteractionSecondDrugs = new HashSet<Interaction>();
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDrugCharts = new HashSet<PrescriptionDrugChart>();
            ProhibitedUsages = new HashSet<ProhibitedUsage>();
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
            ReceptionDrugs = new HashSet<ReceptionDrug>();
            RequestDetails = new HashSet<RequestDetail>();
            SectionEssentialsDrugs = new HashSet<SectionEssentialsDrug>();
            SideEffects = new HashSet<SideEffect>();
            StoreDrugs = new HashSet<StoreDrug>();
            StoreEntryDetails = new HashSet<StoreEntryDetail>();
            StoreTransferDetails = new HashSet<StoreTransferDetail>();
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

        public virtual Unit1 BrokenConsumption { get; set; }
        public virtual Company Company { get; set; }
        public virtual DrugForm DrugForm { get; set; }
        public virtual GenericDrug Generic { get; set; }
        public virtual StoregCondition StoregConditon { get; set; }
        public virtual Unit1 Unit { get; set; }
        public virtual ICollection<DrugStoregCondition> DrugStoregConditions { get; set; }
        public virtual ICollection<Interaction> InteractionFirstDrugs { get; set; }
        public virtual ICollection<Interaction> InteractionSecondDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDrugChart> PrescriptionDrugCharts { get; set; }
        public virtual ICollection<ProhibitedUsage> ProhibitedUsages { get; set; }
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual ICollection<ReceptionDrug> ReceptionDrugs { get; set; }
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
        public virtual ICollection<SectionEssentialsDrug> SectionEssentialsDrugs { get; set; }
        public virtual ICollection<SideEffect> SideEffects { get; set; }
        public virtual ICollection<StoreDrug> StoreDrugs { get; set; }
        public virtual ICollection<StoreEntryDetail> StoreEntryDetails { get; set; }
        public virtual ICollection<StoreTransferDetail> StoreTransferDetails { get; set; }
    }
}
