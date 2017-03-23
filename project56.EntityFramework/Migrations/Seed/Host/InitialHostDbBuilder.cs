using project56.EntityFramework;

namespace project56.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly project56DbContext _context;

        public InitialHostDbBuilder(project56DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
