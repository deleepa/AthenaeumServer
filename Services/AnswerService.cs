using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qna_platform_server.Services
{
    public class AnswerService
    {
        public List<object> GetAllAnswers()
        {
            return new List<object> { ans1, ans2, ans3, ans4 };
        }

        public object GetAnswerById(int id)
        {
            List<object> answers = new List<object> { ans1, ans2, ans3, ans4 };

            foreach (dynamic ans in answers)
            {
                if (ans.Id == id) return ans;
            }

            return null;
        }

        public static object ans1 = new
        {
            Id = 1,
            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
            "Proin laoreet nisl non eros dictum rutrum. Morbi sit amet venenatis urna. " +
            "Sed eu metus quis neque vestibulum malesuada fringilla ut arcu.",
            Username = "John Wick",
            SubmitDate = new DateTime(2019, 02, 02)
        };

        public static object ans2 = new
        {
            Id = 2,
            Text = "Pellentesque id massa congue, viverra mi at, lobortis sem. " +
            "Suspendisse ac tristique dolor, eget suscipit leo. " +
            "Cras sagittis ligula quis eros tempus pharetra. ",
            Username = "Sally Cube",
            SubmitDate = new DateTime(2019, 02, 04)
        };

        public static object ans3 = new
        {
            Id = 3,
            Text = "Donec facilisis vitae sapien et sodales. Ut interdum sapien tellus, " +
            "vel dapibus ex tristique vel. Aenean in bibendum lorem. Sed lobortis non lorem et laoreet.",
            Username = "Interesting Meme",
            SubmitDate = new DateTime(2019, 02, 10)
        };

        public static object ans4 = new
        {
            Id = 3,
            Text = "Sed sed porta ante, sed scelerisque velit. Mauris vitae ipsum est. " +
            "Mauris eget vestibulum turpis. Cras tincidunt purus sit amet nulla blandit accumsan. ",
            Username = "Funny Cat",
            SubmitDate = new DateTime(2019, 02, 15)
        };

    }
}
