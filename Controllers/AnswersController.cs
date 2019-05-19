using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AthenaeumServer.Services;
using AthenaeumServer.Models;

namespace AthenaeumServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {

        AnswerService ansService = new AnswerService();

        [HttpGet]
        public IActionResult Get() 
        {
            try 
            {
                using (var db = new AthenaeumContext())
                {
                    var answers = db.Answer.ToList();

                    return Ok(new {status = true, message = answers});
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
                    var answer = db.Answer
                        .Where(a => a.Id == id)
                        .First();

                    return Ok(new {status = true, message = answer});
                }
            }
            catch(Exception e) 
            {
                return BadRequest(new {status = false, message = e.Message});
            }
        }

        [HttpPost]
        public IActionResult Post(Answer request) 
        {
            try 
            {
                using (var db = new AthenaeumContext()) 
                {
                    db.Add(new Answer() 
                    {
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,  
                        Text = request.Text,
                        UserId = request.UserId,
                        QuestionId = request.QuestionId
                    });

                    db.SaveChanges();
                }
                return Ok();
            }
            catch(Exception e) 
            {
                return BadRequest(new {status = false, message = e.Message});
            }
        }
    }
}