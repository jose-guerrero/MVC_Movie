using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        // url -> http://localhost:5000/HelloWorld/Welcome?name=Rick&id=4
        // url -> http://localhost:5000/HelloWorld/Welcome/4?name=Rick
        public IActionResult Welcome(string name,int numTimes=1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}