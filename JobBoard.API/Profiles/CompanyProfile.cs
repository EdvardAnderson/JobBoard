using AutoMapper;

namespace JobBoard.API;

public class CompanyProfile : Profile
{
    public CompanyProfile()
    {
        CreateMap<Entities.Company, Models.CompanyDto>();
        CreateMap<Entities.Company, Models.CompanyForCreationDto>();
        CreateMap<Models.CompanyDto, Entities.Company>();
        CreateMap<Models.CompanyForCreationDto, Entities.Company>();
    }
}
