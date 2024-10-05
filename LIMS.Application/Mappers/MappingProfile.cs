using AutoMapper;
using LIMS.Application.Commands.Instrument;
using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Handlers.Instrument.InstrumentCommandHandlers;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using LIMS.Domain.Models;

namespace LIMS.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            LaboratoryMappers();
            InstrumentMappers();

            DomainModelAndResponseMapper();
        }

        private void DomainModelAndResponseMapper()
        {
            //Domain Model and Response reverse mapping
            CreateMap<LaboratoryResponse, Laboratory>().ReverseMap();
            CreateMap<TechnicianResponse, Technician>().ReverseMap();
            CreateMap<InstrumentResponse, Instrument>().ReverseMap();
            CreateMap<CalibrationRecordResponse, CalibrationRecord>().ReverseMap();
        }

        private void LaboratoryMappers()
        {
            //Laboratory Commands, Queries and Domain model reverse mapping
            CreateMap<CreateLaboratoryCommand, Laboratory>().ReverseMap();
            CreateMap<DeleteLaboratoryCommand, Laboratory>().ReverseMap();
            CreateMap<UpdateLaboratoryCommand, Laboratory>().ReverseMap();
            CreateMap<GetAllLaboratoryQuery, Laboratory>().ReverseMap();
            CreateMap<GetLaboratoryByIdQuery, Laboratory>().ReverseMap();
        }

        private void InstrumentMappers()
        {
            //Instrument Commands, Queries and Domain model reverse mapping
            CreateMap<CreateInstrumentCommand, Instrument>().ReverseMap();
            CreateMap<UpdateInstrumentCommand, Instrument>().ReverseMap();
            CreateMap<DeleteInstrumentCommand, Instrument>().ReverseMap();
            CreateMap<GetAllInstrumentsQuery, Instrument>().ReverseMap();
            CreateMap<GetInstrumentByIdQuery, Instrument>().ReverseMap();
        }
    }
}
