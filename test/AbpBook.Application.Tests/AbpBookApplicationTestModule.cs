using Volo.Abp.Modularity;

namespace AbpBook;

[DependsOn(
    typeof(AbpBookApplicationModule),
    typeof(AbpBookDomainTestModule)
)]
public class AbpBookApplicationTestModule : AbpModule
{

}
