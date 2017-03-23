using System.Data.Entity.Migrations;
using Abp.Events.Bus;
using Abp.Events.Bus.Entities;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using EntityFramework.DynamicFilters;
using project56.Migrations.Seed.Host;
using project56.Migrations.Seed.Tenants;

namespace project56.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<EntityFramework.project56DbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "project56";
        }

        protected override void Seed(EntityFramework.project56DbContext context)
        {
            context.DisableAllFilters();

            context.EntityChangeEventHelper = NullEntityChangeEventHelper.Instance;
            context.EventBus = NullEventBus.Instance;

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantBuilder(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
                new InitialPeopleCreator(context).Create();
            }
            else
            {
                //You can add seed for tenant databases using Tenant property...
            }

            context.SaveChanges();
        }
    }
}
