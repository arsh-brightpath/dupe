using Abp.Domain.Services;

namespace project56
{
    public abstract class project56DomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected project56DomainServiceBase()
        {
            LocalizationSourceName = project56Consts.LocalizationSourceName;
        }
    }
}
