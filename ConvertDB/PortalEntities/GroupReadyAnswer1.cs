using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class GroupReadyAnswer1
    {
        public int Id { get; set; }
        public int? GroupAnswerId { get; set; }
        public int? ReadyAnswerId { get; set; }
        public string Code { get; set; }
        public int? Arrange { get; set; }

        public virtual GroupAnswer1 GroupAnswer { get; set; }
        public virtual ReadyAnswer1 ReadyAnswer { get; set; }
    }
}
