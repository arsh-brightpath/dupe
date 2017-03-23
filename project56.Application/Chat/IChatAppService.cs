using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using project56.Chat.Dto;

namespace project56.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
