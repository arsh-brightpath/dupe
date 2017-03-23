using System.ComponentModel.DataAnnotations;
using Abp.Localization;

namespace project56.Web.Models.Account
{
    public class VerifySecurityCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [AbpDisplayName(project56Consts.LocalizationSourceName, "Code")]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [AbpDisplayName(project56Consts.LocalizationSourceName, "RememberThisBrowser")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }

        public bool IsRememberBrowserEnabled { get; set; }
    }
}