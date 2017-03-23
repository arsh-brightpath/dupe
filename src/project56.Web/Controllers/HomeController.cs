using System.Web.Mvc;

namespace project56.Web.Controllers
{
    public class HomeController : project56ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}