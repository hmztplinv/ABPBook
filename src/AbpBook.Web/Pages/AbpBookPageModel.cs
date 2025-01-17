using AbpBook.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpBook.Web.Pages;

public abstract class AbpBookPageModel : AbpPageModel
{
    protected AbpBookPageModel()
    {
        LocalizationResourceType = typeof(AbpBookResource);
    }
}
