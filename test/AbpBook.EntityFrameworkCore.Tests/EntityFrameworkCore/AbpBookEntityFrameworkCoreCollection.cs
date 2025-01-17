using Xunit;

namespace AbpBook.EntityFrameworkCore;

[CollectionDefinition(AbpBookTestConsts.CollectionDefinitionName)]
public class AbpBookEntityFrameworkCoreCollection : ICollectionFixture<AbpBookEntityFrameworkCoreFixture>
{

}
