using AutoMapper;
using AbpBook.Books;

namespace AbpBook.Web;

public class AbpBookWebAutoMapperProfile : Profile
{
    public AbpBookWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
