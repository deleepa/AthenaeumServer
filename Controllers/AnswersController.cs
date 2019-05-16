using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AthenaeumServer.Services;

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
            return Ok(ansService.GetAllAnswers());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id) 
        {
            return Ok(ansService.GetAnswerById(id));
        }
    }
}