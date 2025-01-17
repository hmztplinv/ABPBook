using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpBook.Pages;

[Collection(AbpBookTestConsts.CollectionDefinitionName)]
public class Index_Tests : AbpBookWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
