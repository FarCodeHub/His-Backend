using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Section
    {
        public Section()
        {
            AnswerServices = new HashSet<AnswerService>();
            PrescriptionDetailDrugHistories = new HashSet<PrescriptionDetailDrugHistory>();
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDetailServiceHistories = new HashSet<PrescriptionDetailServiceHistory>();
            PrescriptionDetailServices = new HashSet<PrescriptionDetailService>();
            PrescriptionSettings = new HashSet<PrescriptionSetting>();
            Prescriptions = new HashSet<Prescription>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            Reception1s = new HashSet<Reception1>();
            ReceptionDetails = new HashSet<ReceptionDetail>();
            ReceptionDrugConsumerSections = new HashSet<ReceptionDrug>();
            ReceptionDrugSections = new HashSet<ReceptionDrug>();
            ReceptionHistories = new HashSet<ReceptionHistory>();
            ReceptionSectionDoctors = new HashSet<ReceptionSectionDoctor>();
            ReceptionServiceStatuses = new HashSet<ReceptionServiceStatus>();
            ReceptionServices = new HashSet<ReceptionService>();
            RequestSourceSections = new HashSet<Request>();
            RequestTargetSections = new HashSet<Request>();
            RolePermissions = new HashSet<RolePermission>();
            Rooms = new HashSet<Room>();
            SectionEssentialsDrugs = new HashSet<SectionEssentialsDrug>();
            SectionEssentialsGenericDrugs = new HashSet<SectionEssentialsGenericDrug>();
            SectionPropertyLists = new HashSet<SectionPropertyList>();
            SectionServices = new HashSet<SectionService>();
            SectionStoreSections = new HashSet<SectionStore>();
            SectionStoreStores = new HashSet<SectionStore>();
            StoreDrugs = new HashSet<StoreDrug>();
            StoreEntries = new HashSet<StoreEntry>();
            StoreTransferDestinationStores = new HashSet<StoreTransfer>();
            StoreTransferSourceStores = new HashSet<StoreTransfer>();
            UserPermissions = new HashSet<UserPermission>();
            UserRolePermissions = new HashSet<UserRolePermission>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string LocalCode { get; set; }
        public int? CenterId { get; set; }
        public int? BranchId { get; set; }
        public string No { get; set; }
        public string Phone { get; set; }
        public int? SuperVisorPersonelId { get; set; }
        public int? SectionTypeId { get; set; }
        public bool? IsActive { get; set; }
        public int? BossId { get; set; }
        public int? SectionKindId { get; set; }
        public int? SectionFieldId { get; set; }
        public int? TemperatureTypeId { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

        public virtual Employee Boss { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Center Center { get; set; }
        public virtual SectionField SectionField { get; set; }
        public virtual SectionKind SectionKind { get; set; }
        public virtual SectionType SectionType { get; set; }
        public virtual Employee SuperVisorPersonel { get; set; }
        public virtual TemperatureType TemperatureType { get; set; }
        public virtual ICollection<AnswerService> AnswerServices { get; set; }
        public virtual ICollection<PrescriptionDetailDrugHistory> PrescriptionDetailDrugHistories { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailServiceHistory> PrescriptionDetailServiceHistories { get; set; }
        public virtual ICollection<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
        public virtual ICollection<PrescriptionSetting> PrescriptionSettings { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<Reception1> Reception1s { get; set; }
        public virtual ICollection<ReceptionDetail> ReceptionDetails { get; set; }
        public virtual ICollection<ReceptionDrug> ReceptionDrugConsumerSections { get; set; }
        public virtual ICollection<ReceptionDrug> ReceptionDrugSections { get; set; }
        public virtual ICollection<ReceptionHistory> ReceptionHistories { get; set; }
        public virtual ICollection<ReceptionSectionDoctor> ReceptionSectionDoctors { get; set; }
        public virtual ICollection<ReceptionServiceStatus> ReceptionServiceStatuses { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
        public virtual ICollection<Request> RequestSourceSections { get; set; }
        public virtual ICollection<Request> RequestTargetSections { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<SectionEssentialsDrug> SectionEssentialsDrugs { get; set; }
        public virtual ICollection<SectionEssentialsGenericDrug> SectionEssentialsGenericDrugs { get; set; }
        public virtual ICollection<SectionPropertyList> SectionPropertyLists { get; set; }
        public virtual ICollection<SectionService> SectionServices { get; set; }
        public virtual ICollection<SectionStore> SectionStoreSections { get; set; }
        public virtual ICollection<SectionStore> SectionStoreStores { get; set; }
        public virtual ICollection<StoreDrug> StoreDrugs { get; set; }
        public virtual ICollection<StoreEntry> StoreEntries { get; set; }
        public virtual ICollection<StoreTransfer> StoreTransferDestinationStores { get; set; }
        public virtual ICollection<StoreTransfer> StoreTransferSourceStores { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserRolePermission> UserRolePermissions { get; set; }
    }
}
