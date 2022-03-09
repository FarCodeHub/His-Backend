using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class BaseValueType
    {
        public BaseValueType()
        {
            BaseValues = new HashSet<BaseValue>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public string UniqueName { get; set; }
        public string GroupName { get; set; }
        public bool IsReadOnly { get; set; }
        public string SubSystem { get; set; }

        public virtual ICollection<BaseValue> BaseValues { get; set; }
    }
}
