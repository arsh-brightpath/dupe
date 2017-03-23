using Abp.WebApi.Controllers;

namespace project56.WebApi
{
    public abstract class project56ApiControllerBase : AbpApiController
    {
        protected project56ApiControllerBase()
        {
            LocalizationSourceName = project56Consts.LocalizationSourceName;
        }
    }
}