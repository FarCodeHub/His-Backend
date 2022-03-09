using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Product
    {
        public long Id { get; set; }
        public long? OnlineId { get; set; }
        public string Enname { get; set; }
        public string Fullname { get; set; }
    }
}
