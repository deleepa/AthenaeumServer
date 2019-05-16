using System;
using System.Collections.Generic;

namespace AthenaeumServer.Models
{
    public partial class User
    {
        public User()
        {
            Answer = new HashSet<Answer>();
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<Answer> Answer { get; set; }
        public virtual ICollection<Question> Question { get; set; }
    }
}
