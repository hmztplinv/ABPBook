using System.Threading.Tasks;

namespace AbpBook.Data;

public interface IAbpBookDbSchemaMigrator
{
    Task MigrateAsync();
}
