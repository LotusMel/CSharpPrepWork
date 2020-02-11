using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC2020.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/

        //displays form
        [HttpGet]
        public IActionResult Index()
        {
            //build form
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                "<option value ='english' selected>English</option>" +
                "<option value ='french'>French</option>" +
                "<option value ='spanish'>Spanish</option>" +
                "<option value ='italian'>Italian</option>" +
                "<option value ='russian'>Russian</option>" +
                "<option value ='greek'>Greek</option>" +
                "</select> " +
                "<input type='submit' value='Greet me!'/>" +
                "</form>";

            return Content(html, "text/html");
        }

        //responds to POST requests

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string language, string name)
        {
            
            string greeting = CreateMessage(language, name);
            return Content(string.Format("<h2><em>{0}!</h2>", greeting), "text/html");
        }

        public static string CreateMessage(string lang, string name)
        {
            if (lang.Equals("spanish"))
            {
                return "Hola, " + name;
            }
            else if (lang.Equals("french"))
            {
                return "Bonjour, " + name;
            }
            else if (lang.Equals("russian"))
            {
                return "Priviet, " + name;
            }
            else if (lang.Equals("italian"))
            {
                return "Ciao, " + name;
            }
            else if (lang.Equals("greek"))
            {
                return "Yassou, " + name;
            }
            else
            {
                return "Hello, " + name;
            }
        }
    }
}
