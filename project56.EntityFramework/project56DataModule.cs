using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using project56.EntityFramework;

namespace project56
{
    /// <summary>
    /// Entity framework module of the application.
    /// </summary>
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(project56CoreModule))]
    public class project56DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<project56DbContext>());

            //web.config (or app.config for non-web projects) file should contain a connection string named "Default".
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
