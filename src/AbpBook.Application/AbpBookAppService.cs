using AbpBook.Localization;
using Volo.Abp.Application.Services;

namespace AbpBook;

/* Inherit your application services from this class.
 */
public abstract class AbpBookAppService : ApplicationService
{
    protected AbpBookAppService()
    {
        LocalizationResource = typeof(AbpBookResource);
    }
}
