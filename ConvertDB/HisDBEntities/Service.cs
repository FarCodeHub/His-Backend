using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class Service
    {
        public Service()
        {
            InverseParent = new HashSet<Service>();
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

        public virtual Service Parent { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<Service> InverseParent { get; set; }
    }
}
