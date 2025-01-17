using AbpBook.Samples;
using Xunit;

namespace AbpBook.EntityFrameworkCore.Domains;

[Collection(AbpBookTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpBookEntityFrameworkCoreTestModule>
{

}
