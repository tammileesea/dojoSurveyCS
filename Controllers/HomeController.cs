using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoSurvey.Models;

namespace dojoSurvey.Controllers{
    public class HomeController : Controller {
        [HttpGet("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(Dojo newUser){
            if (ModelState.IsValid){
                return View("Result", newUser);
            } else {
                return View("Index");
            }
        }
    }
}