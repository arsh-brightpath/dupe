using System.Web.Mvc;
using Abp.Auditing;

namespace project56.Web.Controllers
{
    public class ErrorController : project56ControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}