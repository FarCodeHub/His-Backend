using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class GroupReadyAnswer
    {
        public int Id { get; set; }
        public int? GroupAnswerId { get; set; }
        public int? ReadyAnswerId { get; set; }
        public string Code { get; set; }
        public int? Arrange { get; set; }
        public bool? IsCommon { get; set; }

        public virtual GroupAnswer GroupAnswer { get; set; }
        public virtual ReadyAnswer ReadyAnswer { get; set; }
    }
}
