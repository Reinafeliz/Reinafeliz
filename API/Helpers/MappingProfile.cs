using System.Linq;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.MasterAggregate;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Countries, CountriesDto>();
            // CreateMap<Clinic, ClinicDto>()
            //  .ForMember(d => d.City, o => o.MapFrom(s => s.StateCity.Name))
            //  .ForMember(d => d.Country, o => o.MapFrom(s => s.StateCity.Country.Name))
            //  .ForMember(d => d.ClinicType, o => o.MapFrom(s => s.ClinicType.Name))
            //  .ForMember(d => d.Speciality, o => o.MapFrom(s => s.Speciality.Name))
            //  .ForMember(d => d.LogoUrl, o => o.MapFrom<ClinicUrlResolver>());
        }
    }
}