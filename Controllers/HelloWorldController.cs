using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // url -> http://localhost:5000/HelloWorld/Welcome?name=Rick&id=4
        // url -> http://localhost:5000/HelloWorld/Welcome/4?name=Rick
        public string Welcome(string name,int ID=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}