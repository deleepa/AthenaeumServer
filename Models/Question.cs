using System;
using System.Collections.Generic;

namespace AthenaeumServer.Models
{
    public partial class Question
    {
        public Question()
        {
            QuestionAnswer = new HashSet<QuestionAnswer>();
        }

        public string MainText { get; set; }
        public string SecondaryText { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Id { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswer { get; set; }
    }
}
