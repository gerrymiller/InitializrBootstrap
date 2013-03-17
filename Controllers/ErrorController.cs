using System.Web.Mvc;

namespace InitializrBootstrap.Controllers
{
  [AllowAnonymous]
  public class ErrorController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult NotFound()
    {
      return View();
    }

    public ActionResult AccessDenied()
    {
      return View();
    }
  }
}
