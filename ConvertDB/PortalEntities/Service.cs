using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Service
    {
        public Service()
        {
            CenterServices = new HashSet<CenterService>();
            DefineRoutineTests = new HashSet<DefineRoutineTest>();
            Instructions = new HashSet<Instruction>();
            InverseParent = new HashSet<Service>();
            PrescriptionDetailServices = new HashSet<PrescriptionDetailService>();
            PrescriptionGroupSettings = new HashSet<PrescriptionGroupSetting>();
            PrescriptionServiceResults = new HashSet<PrescriptionServiceResult>();
            PrescriptionServiceRoutines = new HashSet<PrescriptionServiceRoutine>();
            PrescriptionSettingServiceGroups = new HashSet<PrescriptionSetting>();
            PrescriptionSettingServices = new HashSet<PrescriptionSetting>();
            ReceptionServiceServiceChildren = new HashSet<ReceptionService>();
            ReceptionServiceServices = new HashSet<ReceptionService>();
            RelatedTestMainServices = new HashSet<RelatedTest>();
            RelatedTestSubServices = new HashSet<RelatedTest>();
            RichLongAnswers = new HashSet<RichLongAnswer>();
            SectionServices = new HashSet<SectionService>();
            ServiceCodings = new HashSet<ServiceCoding>();
            TestAnswerTimes = new HashSet<TestAnswerTime>();
            TestRanges = new HashSet<TestRange>();
        }

        public int Id { get; set; }
        public int? Code { get; set; }
        public string LocalCode { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public decimal? BasePrice { get; set; }
        public string InterNationalCode { get; set; }
        public string LatinDescription { get; set; }
        public int? IcdCodeId { get; set; }
        public int? ParentId { get; set; }
        public int? ServiceTypeId { get; set; }
        public bool? IsActive { get; set; }
        public int? ServiceLevelId { get; set; }
        public string Note { get; set; }
        public string NoteLang2 { get; set; }
        public int? Info { get; set; }
        public int? UnitId { get; set; }
        public int? SampleTypeId { get; set; }
        public decimal? SampleSize { get; set; }
        public int? TestTubeColorId { get; set; }
        public bool? IsDiff { get; set; }
        public string AbbreviationTitle { get; set; }
        public int? LabTypeId { get; set; }
        public int? LabKitId { get; set; }
        public bool? IsNumeric { get; set; }
        public bool? IsHasAttachment { get; set; }
        public int? HourToResponseNormal { get; set; }
        public int? HourToResponseEmergency { get; set; }
        public string FormulaExpr { get; set; }
        public bool? IsLongAnswer { get; set; }
        public int? GroupAnswerId { get; set; }
        public int? TestAnswerTypeId { get; set; }
        public int? Arrange { get; set; }
        public int? DataTypeId { get; set; }
        public bool? HasBiopsy { get; set; }
        public bool? IsAnswerAtMoment { get; set; }
        public int? RichLongAnswerId { get; set; }
        public string Component { get; set; }
        public string RelatedNames { get; set; }
        public string LongCommonName { get; set; }
        public int? TimeAspctId { get; set; }
        public int? MethodTypeId { get; set; }
        public int? OrderObservationId { get; set; }
        public int? ScaleTypeId { get; set; }
        public int? PropertyId { get; set; }
        public bool? IsCommon { get; set; }
        public bool? IsLaboratoryOrderPanels { get; set; }

        public virtual DataType DataType { get; set; }
        public virtual GroupAnswer1 GroupAnswer { get; set; }
        public virtual MethodType MethodType { get; set; }
        public virtual Service Parent { get; set; }
        public virtual Property Property { get; set; }
        public virtual RichLongAnswer RichLongAnswer { get; set; }
        public virtual ScaleType ScaleType { get; set; }
        public virtual ServiceLevel ServiceLevel { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual TestAnswerType TestAnswerType { get; set; }
        public virtual TimeAspct TimeAspct { get; set; }
        public virtual ICollection<CenterService> CenterServices { get; set; }
        public virtual ICollection<DefineRoutineTest> DefineRoutineTests { get; set; }
        public virtual ICollection<Instruction> Instructions { get; set; }
        public virtual ICollection<Service> InverseParent { get; set; }
        public virtual ICollection<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
        public virtual ICollection<PrescriptionGroupSetting> PrescriptionGroupSettings { get; set; }
        public virtual ICollection<PrescriptionServiceResult> PrescriptionServiceResults { get; set; }
        public virtual ICollection<PrescriptionServiceRoutine> PrescriptionServiceRoutines { get; set; }
        public virtual ICollection<PrescriptionSetting> PrescriptionSettingServiceGroups { get; set; }
        public virtual ICollection<PrescriptionSetting> PrescriptionSettingServices { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServiceServiceChildren { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServiceServices { get; set; }
        public virtual ICollection<RelatedTest> RelatedTestMainServices { get; set; }
        public virtual ICollection<RelatedTest> RelatedTestSubServices { get; set; }
        public virtual ICollection<RichLongAnswer> RichLongAnswers { get; set; }
        public virtual ICollection<SectionService> SectionServices { get; set; }
        public virtual ICollection<ServiceCoding> ServiceCodings { get; set; }
        public virtual ICollection<TestAnswerTime> TestAnswerTimes { get; set; }
        public virtual ICollection<TestRange> TestRanges { get; set; }
    }
}
