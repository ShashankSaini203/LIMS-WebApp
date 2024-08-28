using Autofac;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands;
using LIMS.Application.Handlers.Laboratory.CommandHandlers;
using LIMS.Application.Responses;
using MediatR;
using LIMS.Application.Commands.Laboratory;
using LIMS.Infrastructure.Repository.Queries;
using LIMS.Domain.Interfaces.Repository.Query;
using LIMS.Application.Handlers.Laboratory.QueryHandlers;
using LIMS.Application.Queries.Laboratory;
using LIMS.Infrastructure.Database.DBConnector;

namespace LIMS.WebApp
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<DBConnector>().As<IDBConnector>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<DataContext>().AsSelf().InstancePerLifetimeScope();
            containerBuilder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

            # region Repository
            containerBuilder.RegisterType<LabCommandRepository>().As<ILabCommandRepository>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<LabQueryRepository>().As<ILabQueryRepository>().InstancePerLifetimeScope();
            #endregion

            #region Handlers
            containerBuilder.RegisterType<CreateLaboratoryCommandHandler>().As<IRequestHandler<CreateLaboratoryCommand, LaboratoryResponse>>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<UpdateLaboratoryCommandHandler>().As<IRequestHandler<UpdateLaboratoryCommand, LaboratoryResponse>>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<DeleteLaboratoryCommandHandler>().As<IRequestHandler<DeleteLaboratoryCommand, Unit>>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<GetAllLaboratoryQueryHandler>().As<IRequestHandler<GetAllLaboratoryQuery, IEnumerable<LaboratoryResponse>>>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<GetLaboratoryByIdQueryHandler>().As<IRequestHandler<GetLaboratoryByIdQuery, LaboratoryResponse>>().InstancePerLifetimeScope();
            #endregion
        }
    }
}
