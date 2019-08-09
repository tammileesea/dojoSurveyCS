using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey{
    public class HomeController : Controller {
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string NameField, string LocationField, string LanguageField, string CommentField){
            System.Console.WriteLine(CommentField);
            ViewBag.Name = NameField;
            ViewBag.Location = LocationField;
            ViewBag.Language = LanguageField;
            ViewBag.Comment = CommentField;
            return View();
        }
    }
}