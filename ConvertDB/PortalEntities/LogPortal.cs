using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class LogPortal
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Body { get; set; }
        public string ServerName { get; set; }
        public string Ip { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Host { get; set; }
        public string Url { get; set; }
        public bool? UserAuthenticated { get; set; }
        public string UserAgent { get; set; }
        public string ThreadName { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }
        public string SiteName { get; set; }
    }
}
