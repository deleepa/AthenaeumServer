using System;
using System.Collections.Generic;

namespace AthenaeumServer.Models
{
    public partial class QuestionAnswer
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual Question Question { get; set; }
    }
}
