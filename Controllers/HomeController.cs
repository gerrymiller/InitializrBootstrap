using System.Web.Mvc;

namespace InitializrBootstrap.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/

        public ActionResult About()
        {
            return View();
        }

        // GET: /Home/

        public ActionResult Contact()
        {
            return View();
        }

    }
}
