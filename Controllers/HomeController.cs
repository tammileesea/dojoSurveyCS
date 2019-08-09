using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoSurvey.Models;

using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey{
    public class HomeController : Controller {
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(Dojo newUser){
            System.Console.WriteLine(newUser.Name);
            return View("Result", newUser);
        }
    }
}