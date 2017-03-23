using System.Collections.Generic;

namespace project56.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}