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
                "<select>" +
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
        public IActionResult Display(string name = "World")
        {
            private static string GetMessage(string lang)
            {
                if (lang.Equals("spanish"))
                {
                    return "Hola Mundo";
                }
                else if (lang.Equals("french"))
                {
                    return "Bonjour le monde";
                }
                else
                {
                    return "Hello World";
                }
            }
            return Content(string.Format("<h1>{0}, {1}!</h1>", , name), "text/html");
        }
    }
}
