using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            ReceptionAnswers = new HashSet<ReceptionAnswer>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public int? Arrange { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<ReceptionAnswer> ReceptionAnswers { get; set; }
    }
}
