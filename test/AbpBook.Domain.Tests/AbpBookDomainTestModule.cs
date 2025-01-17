using Volo.Abp.Modularity;

namespace AbpBook;

[DependsOn(
    typeof(AbpBookDomainModule),
    typeof(AbpBookTestBaseModule)
)]
public class AbpBookDomainTestModule : AbpModule
{

}
