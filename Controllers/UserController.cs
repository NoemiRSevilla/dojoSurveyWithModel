using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoSurveyWithModel.Models;

namespace dojoSurveyWithModel.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(string name, string dojo_location, string favorite_language, string comments)
        {
            return View();
        }
        [HttpPost("survey")]
        public IActionResult Submission(string name, string dojo_location, string favorite_language, string comments)
        {
            Survey newSurvey = new Survey();
            newSurvey.name = name;
            newSurvey.dojo_location = dojo_location;
            newSurvey.favorite_language = favorite_language;
            newSurvey.comments = comments;
            return View("Submission", newSurvey);
        }
    }
}
