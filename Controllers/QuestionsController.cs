using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AthenaeumServer.Services;
using AthenaeumServer.Models;

namespace AthenaeumServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : Controller
    {
        QuestionService qsService = new QuestionService();

        public IActionResult Get()
        {
            try 
            {
                using (var db = new AthenaeumContext())
                {
                    var question = db.Question.ToList();

                    return Ok(new {status = true, message = question});
                }
            }
            catch(Exception e) 
            {
                return BadRequest(new {status = false, message = e.Message});
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            try 
            {
                using (var db = new AthenaeumContext())
                {
                    var question = db.Question
                        .Where(q => q.Id == id)
                        .First();

                    return Ok(new {status = true, message = question});
                }
            }
            catch(Exception e) 
            {
                return BadRequest(new {status = false, message = e.Message});
            }
        }

        [HttpGet]
        [Route("{id}/answers")]
        public IActionResult GetAnswersForQuestion(int id)
        {
            try
            {
                using (var db = new AthenaeumContext())
                {
                    var answers = db.Answer
                        .Where(a => a.QuestionId == id)
                        .ToList();

                    return Ok(new {status = true, message = answers});
                }
            }
            catch(Exception e) 
            {
                return BadRequest(new {status = false, message = e.Message});
            }
        }

        [HttpPost]
        public IActionResult Post(Question request)
        {
            try 
            {
                using (var db = new AthenaeumContext())
                {
                    db.Add(new Question()
                    {
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        MainText = request.MainText,
                        SecondaryText = request.SecondaryText,
                        UserId = request.UserId
                    });

                    db.SaveChanges();
                }
                return Ok();
            }
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }
        }
    }
}