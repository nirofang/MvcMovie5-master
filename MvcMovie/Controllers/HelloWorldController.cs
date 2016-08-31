//Example tutorial links
//http://www.asp.net/mvc/overview/getting-started/introduction/adding-a-model
//http://www.asp.net/web-pages/overview/getting-started/introducing-razor-syntax-c
//http://www.asp.net/mvc/overview/views/using-page-inspector-in-aspnet-mvc



using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}
