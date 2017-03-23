using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using project56.Authorization.Users;
using project56.MultiTenancy;

namespace project56.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
