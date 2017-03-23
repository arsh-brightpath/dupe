using EntityFramework.DynamicFilters;
using project56.EntityFramework;

namespace project56.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly project56DbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(project56DbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
