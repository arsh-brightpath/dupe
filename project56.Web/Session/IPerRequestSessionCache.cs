using System.Threading.Tasks;
using project56.Sessions.Dto;

namespace project56.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
