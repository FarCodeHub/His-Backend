using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Answer
    {
        public Answer()
        {
            ReceptionAnswers = new HashSet<ReceptionAnswer>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? QuestionId { get; set; }
        public string Code { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }
        public int? Arrange { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<ReceptionAnswer> ReceptionAnswers { get; set; }
    }
}
