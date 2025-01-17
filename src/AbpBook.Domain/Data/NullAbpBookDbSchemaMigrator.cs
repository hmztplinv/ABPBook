using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpBook.Data;

/* This is used if database provider does't define
 * IAbpBookDbSchemaMigrator implementation.
 */
public class NullAbpBookDbSchemaMigrator : IAbpBookDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
