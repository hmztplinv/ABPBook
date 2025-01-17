using Microsoft.AspNetCore.Builder;
using AbpBook;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("AbpBook.Web.csproj"); 
await builder.RunAbpModuleAsync<AbpBookWebTestModule>(applicationName: "AbpBook.Web");

public partial class Program
{
}
