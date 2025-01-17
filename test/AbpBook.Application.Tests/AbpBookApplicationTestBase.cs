using Volo.Abp.Modularity;

namespace AbpBook;

public abstract class AbpBookApplicationTestBase<TStartupModule> : AbpBookTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
