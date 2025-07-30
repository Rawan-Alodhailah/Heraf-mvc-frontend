using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class Craftsman : Controller
    {
        // GET: Craftsman
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
    }
}
