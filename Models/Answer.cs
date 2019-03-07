using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qna_platform_server.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public DateTime SubmitDate { get; set; }
        public string Text { get; set; }
    }
}
