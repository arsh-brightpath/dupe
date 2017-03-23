using Abp.Notifications;
using project56.Dto;

namespace project56.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}