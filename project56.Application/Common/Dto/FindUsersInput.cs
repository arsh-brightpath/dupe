using project56.Dto;

namespace project56.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}