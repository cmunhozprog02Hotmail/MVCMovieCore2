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

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

            ;
        }
    }
}
