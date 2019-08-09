using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey{
    public class HomeController : Controller {
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string NameField, string LocationField, string LanguageField, string CommentField){
            System.Console.WriteLine(NameField);
            string Name = NameField;
            string Location = LocationField;
            string Language = LanguageField;
            string Comment = CommentField;
            return View();
        }
    }
}