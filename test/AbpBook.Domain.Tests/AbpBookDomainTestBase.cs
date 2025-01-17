using Volo.Abp.Modularity;

namespace AbpBook;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpBookDomainTestBase<TStartupModule> : AbpBookTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
