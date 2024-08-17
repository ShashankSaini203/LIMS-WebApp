using Autofac;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands;
using LIMS.Application.Handlers.Laboratory.CommandHandlers;
using LIMS.Application.Responses;
using MediatR;
using LIMS.Application.Commands.Laboratory;

namespace LIMS.WebApp
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<DataContext>().AsSelf().InstancePerLifetimeScope();
            containerBuilder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

            # region Repository
            containerBuilder.RegisterType<LabCommandRepository>().As<ILabCommandRepository>().SingleInstance();
            #endregion

            #region Handlers
            containerBuilder.RegisterType<CreateLaboratoryCommandHandler>().As<IRequestHandler<CreateLaboratoryCommand, LaboratoryResponse>>().InstancePerLifetimeScope();
            #endregion
        }
    }
}
