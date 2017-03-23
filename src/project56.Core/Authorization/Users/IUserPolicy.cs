using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace project56.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
