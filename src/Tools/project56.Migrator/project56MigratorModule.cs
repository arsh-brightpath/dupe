using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using project56.EntityFramework;

namespace project56.Migrator
{
    [DependsOn(typeof(project56DataModule))]
    public class project56MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<project56DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}