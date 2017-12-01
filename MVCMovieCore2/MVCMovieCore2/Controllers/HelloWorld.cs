// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovieCore2.Controllers
{
    public class HelloWorld : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View(); 
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {

            ViewData["Message"] = "Olá " + name;
            ViewData["numTimes"] = numTimes;

            return View();
             
        }
    }
}
