using AbpBook.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpBook.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpBookController : AbpControllerBase
{
    protected AbpBookController()
    {
        LocalizationResource = typeof(AbpBookResource);
    }
}
