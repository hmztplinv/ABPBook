using AbpBook.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpBook.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpBookEntityFrameworkCoreModule),
    typeof(AbpBookApplicationContractsModule)
)]
public class AbpBookDbMigratorModule : AbpModule
{
}
