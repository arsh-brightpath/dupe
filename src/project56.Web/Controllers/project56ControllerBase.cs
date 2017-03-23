using Abp.IdentityFramework;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using Microsoft.AspNet.Identity;

namespace project56.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// Add your methods to this class common for all controllers.
    /// </summary>
    public abstract class project56ControllerBase : AbpController
    {
        protected project56ControllerBase()
        {
            LocalizationSourceName = project56Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}