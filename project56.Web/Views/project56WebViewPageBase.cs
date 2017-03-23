using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace project56.Web.Views
{
    public abstract class project56WebViewPageBase : project56WebViewPageBase<dynamic>
    {
       
    }

    public abstract class project56WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected project56WebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = project56Consts.LocalizationSourceName;
        }
    }
}