namespace project56.Web.MultiTenancy
{
    public interface ITenancyNameFinder
    {
        string GetCurrentTenancyNameOrNull();
    }
}