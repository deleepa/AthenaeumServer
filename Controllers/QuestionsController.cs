﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using qna_platform_server.Services;

namespace qna_platform_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : Controller
    {
        QuestionService qsService = new QuestionService();

        public IActionResult Get()
        {
            //Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(qsService.GetQuestions());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            //Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(qsService.GetQuestionById(id));
        }
    }
}