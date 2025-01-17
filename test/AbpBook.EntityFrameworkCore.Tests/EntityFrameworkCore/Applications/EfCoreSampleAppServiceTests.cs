using AbpBook.Samples;
using Xunit;

namespace AbpBook.EntityFrameworkCore.Applications;

[Collection(AbpBookTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpBookEntityFrameworkCoreTestModule>
{

}
