using System.ComponentModel.DataAnnotations;
using project56.Authorization.Users;
using project56.MultiTenancy;

namespace project56.Web.Models.TenantRegistration
{
    public class TenantRegistrationViewModel
    {
        [Required]
        [StringLength(Tenant.MaxTenancyNameLength)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(User.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(User.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }

        [StringLength(User.MaxPlainPasswordLength)]
        public string AdminPassword { get; set; }
    }
}