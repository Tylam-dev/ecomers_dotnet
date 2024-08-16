using AutoMapper;

namespace ecomers_dotnet;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Categories, CategoryDto>();
    }
}
