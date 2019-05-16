using AthenaeumServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthenaeumServer.Services
{
    public class QuestionService
    {
        public List<object> GetQuestions()
        {

            return new List<object> { question1, question2 };
        }

        public object GetQuestionById(int id)
        {
            List<object> questions = new List<object> { question1, question2 };

            foreach (dynamic question in questions)
            {
                if (question.Id == id) return question;
            }

            return null;
        }

        public static object question1 = new
        {
            Id = 1,
            Question = new
            {
                MainText = "Vivamus ut nunc diam. Sed molestie, tellus sit amet dapibus feugiat, nibh enim?",
                SecondaryText = "Etiam quis mi varius, tempor eros vitae, suscipit nisl. Cras fringilla pellentesque turpis ut consequat. " +
                "Interdum et malesuada fames ac ante ipsum primis in faucibus. Aenean in blandit ipsum.",
            },
            AnswerList = new List<object> { AnswerService.ans1, AnswerService.ans3, AnswerService.ans2, },
            Username = "Sue Rogers",
            SubmitDate = new DateTime(2019, 01, 18)
        };

        public static object question2 = new
        {
            Id = 2,
            Question = new
            {
                MainText = "Sed molestie, tellus sit amet dapibus feugiat, nibh enim congue orci?",
                SecondaryText = "Nam tristique lorem sed pharetra fermentum. Suspendisse ac bibendum est, non " +
                "dapibus tellus. In auctor ipsum eu molestie consequat. Etiam egestas est a finibus viverra.",
            },
            AnswerList = new List<object> { AnswerService.ans2, AnswerService.ans4, AnswerService.ans1, },
            Username = "Jaded Letter",
            SubmitDate = new DateTime(2019, 01, 20)
        };
    }
}
