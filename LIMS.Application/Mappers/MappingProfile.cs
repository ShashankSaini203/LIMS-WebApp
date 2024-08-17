using AutoMapper;
using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using LIMS.Domain.Models;

namespace LIMS.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Commands and Queries to Domain Contracts mapping
            CreateMap<CreateLaboratoryCommand, Laboratory>().ReverseMap();
            CreateMap<DeleteLaboratoryCommand, Laboratory>().ReverseMap();
            CreateMap<UpdateLaboratoryCommand, Laboratory>().ReverseMap();
            CreateMap<GetAllLaboratoryQuery, Laboratory>().ReverseMap();
            CreateMap<GetLaboratoryByIdQuery, Laboratory>().ReverseMap();

            //Responses to Domain Contracts mapping
            CreateMap<LaboratoryResponse, Laboratory>().ReverseMap();
            CreateMap<TechnicianResponse, Technician>().ReverseMap();
            CreateMap<InstrumentResponse, Instrument>().ReverseMap();
            CreateMap< CalibrationRecordResponse, CalibrationRecord>().ReverseMap();
        }
    }
}
