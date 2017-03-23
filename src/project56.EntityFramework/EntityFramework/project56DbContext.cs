using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using project56.Authorization.Roles;
using project56.Authorization.Users;
using project56.Chat;
using project56.Friendships;
using project56.MultiTenancy;
using project56.Storage;

namespace project56.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class project56DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public virtual IDbSet<Person> Persons { get; set; }

        public project56DbContext()
            : base("Default")
        {
            
        }

        public project56DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public project56DbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public project56DbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
