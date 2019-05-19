using System;
using System.Collections.Generic;

namespace AthenaeumServer.Models
{
    public class Question
    {
        public string MainText { get; set; }
        public string SecondaryText { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
