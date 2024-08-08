using Autofac;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands;

namespace LIMS.WebApp
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<DataContext>().AsSelf().InstancePerLifetimeScope();

            //Commands
            containerBuilder.RegisterType<LabCommandRepository>().As<ILabCommandRepository>().SingleInstance();
        }
    }
}
