using AbpBook.Books;
using Xunit;

namespace AbpBook.EntityFrameworkCore.Applications.Books;

[Collection(AbpBookTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<AbpBookEntityFrameworkCoreTestModule>
{

}