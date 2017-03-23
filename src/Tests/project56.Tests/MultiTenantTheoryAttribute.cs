using Xunit;

namespace project56.Tests
{
    public sealed class MultiTenantTheoryAttribute : TheoryAttribute
    {
        public MultiTenantTheoryAttribute()
        {
            var multiTenancyConfig = System.Configuration.ConfigurationManager.AppSettings["MultiTenancyEnabled"];
            if (multiTenancyConfig != null && multiTenancyConfig == "false")
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}