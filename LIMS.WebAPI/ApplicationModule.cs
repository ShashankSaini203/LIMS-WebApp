using Autofac;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands;
using LIMS.Application.Responses;
using MediatR;
using LIMS.Application.Commands.Laboratory;
using LIMS.Infrastructure.Repository.Queries;
using LIMS.Domain.Interfaces.Repository.Query;
using LIMS.Application.Queries.Laboratory;
using LIMS.Infrastructure.Database.DBConnector;
using LIMS.Application.Commands.Instrument;
using LIMS.Application.Handlers.Instrument.InstrumentCommandHandlers;
using LIMS.Application.Handlers.Laboratory.LaboratoryCommandHandlers;
using LIMS.Application.Handlers.Laboratory.LaboratoryQueryHandlers;
using LIMS.Application.Handlers.Instrument.InstrumentQueryHandler;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Commands.Technician;
using LIMS.Application.Queries.Technician;

namespace LIMS.WebAPI
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DBConnector>().As<IDBConnector>().InstancePerLifetimeScope();
            builder.RegisterType<DataContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

            RegisterLaboratoryDependencies(builder);
            RegisterInstrumentDependencies(builder);
        }

        private void RegisterLaboratoryDependencies(ContainerBuilder builder)
        {
            # region Laboratory Repository
            builder.RegisterType<LabCommandRepository>().As<ILabCommandRepository>().InstancePerLifetimeScope();
            builder.RegisterType<LabQueryRepository>().As<ILabQueryRepository>().InstancePerLifetimeScope();
            #endregion

            #region Laboratory Handlers
            builder.RegisterType<CreateLaboratoryCommandHandler>().As<IRequestHandler<CreateLaboratoryCommand, LaboratoryResponse>>().InstancePerLifetimeScope();
            builder.RegisterType<UpdateLaboratoryCommandHandler>().As<IRequestHandler<UpdateLaboratoryCommand, LaboratoryResponse>>().InstancePerLifetimeScope();
            builder.RegisterType<DeleteLaboratoryCommandHandler>().As<IRequestHandler<DeleteLaboratoryCommand, Unit>>().InstancePerLifetimeScope();
            builder.RegisterType<GetAllLaboratoryQueryHandler>().As<IRequestHandler<GetAllLaboratoryQuery, IEnumerable<LaboratoryResponse>>>().InstancePerLifetimeScope();
            builder.RegisterType<GetLaboratoryByIdQueryHandler>().As<IRequestHandler<GetLaboratoryByIdQuery, LaboratoryResponse>>().InstancePerLifetimeScope();
            #endregion
        }

        private void RegisterInstrumentDependencies(ContainerBuilder builder)
        {
            #region Instrument Repository
            builder.RegisterType<InstrumentCommandRepository>().As<IInstrumentCommandRepository>().InstancePerLifetimeScope();
            builder.RegisterType<InstrumentQueryRepository>().As<IInstrumentQueryRepository>().InstancePerLifetimeScope();
            #endregion

            #region Instrument Handlers
            builder.RegisterType<CreateInstrumentCommandHandler>().As<IRequestHandler<CreateInstrumentCommand, InstrumentResponse>>().InstancePerLifetimeScope();
            builder.RegisterType<UpdateInstrumentCommandHandler>().As<IRequestHandler<UpdateInstrumentCommand, InstrumentResponse>>().InstancePerLifetimeScope();
            builder.RegisterType<DeleteInstrumentCommandHandler>().As<IRequestHandler<DeleteInstrumentCommand, Unit>>().InstancePerLifetimeScope();
            builder.RegisterType<GetInstrumentByIdQueryHandler>().As<IRequestHandler<GetInstrumentByIdQuery, InstrumentResponse>>().InstancePerLifetimeScope();
            builder.RegisterType<GetAllInstrumentsQueryHandler>().As<IRequestHandler<GetAllInstrumentsQuery, IEnumerable<InstrumentResponse>>>().InstancePerLifetimeScope();
            #endregion
        }

        private void RegisterTechnicianDependencies(ContainerBuilder builder)
        {
            #region Technician Repository
            builder.RegisterType<TechnicianCommandRepository>().As<ITechnicianCommandRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TechnicianQueryRepository>().As<ITechnicianQueryRepository>().InstancePerLifetimeScope();
            #endregion

            #region Technician Handlers
            builder.RegisterType<CreateTechnicianCommandHandler>().As<IRequestHandler<CreateTechnicianCommand, TechnicianResponse>>().InstancePerLifetimeScope();
            builder.RegisterType<UpdateTechnicianCommandHandler>().As<IRequestHandler<UpdateTechnicianCommand, TechnicianResponse>>().InstancePerLifetimeScope();
                        #endregion
        }


    }
}
