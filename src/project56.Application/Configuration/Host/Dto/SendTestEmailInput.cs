using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using project56.Authorization.Users;

namespace project56.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}