using System;
using System.Collections.Generic;

namespace AthenaeumServer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
