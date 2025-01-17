using AutoMapper;
using AbpBook.Books;

namespace AbpBook;

public class AbpBookApplicationAutoMapperProfile : Profile
{
    public AbpBookApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
