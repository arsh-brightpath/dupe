using Xunit;

namespace project56.Tests
{
    public sealed class MultiTenantFactAttribute : FactAttribute
    {
        public MultiTenantFactAttribute()
        {
            var multiTenancyConfig = System.Configuration.ConfigurationManager.AppSettings["MultiTenancyEnabled"];
            if (multiTenancyConfig != null && multiTenancyConfig == "false")
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}