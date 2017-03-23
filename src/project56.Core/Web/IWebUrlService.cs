namespace project56.Web
{
    public interface IWebUrlService
    {
        string GetSiteRootAddress(string tenancyName = null);
    }
}
