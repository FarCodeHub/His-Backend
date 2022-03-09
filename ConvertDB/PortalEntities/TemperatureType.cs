using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class TemperatureType
    {
        public TemperatureType()
        {
            Sections = new HashSet<Section>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Range { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
    }
}
