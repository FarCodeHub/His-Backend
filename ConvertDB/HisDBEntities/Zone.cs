﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class Zone
    {
        public Zone()
        {
            InverseParent = new HashSet<Zone>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? ParentId { get; set; }
        public int? LevelId { get; set; }
        public int? CityId { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }
        public int? LocalId { get; set; }

        public virtual City City { get; set; }
        public virtual Zone Parent { get; set; }
        public virtual ICollection<Zone> InverseParent { get; set; }
    }
}
