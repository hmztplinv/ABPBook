using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using AbpBook.Localization;

namespace AbpBook.Web;

[Dependency(ReplaceServices = true)]
public class AbpBookBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpBookResource> _localizer;

    public AbpBookBrandingProvider(IStringLocalizer<AbpBookResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
