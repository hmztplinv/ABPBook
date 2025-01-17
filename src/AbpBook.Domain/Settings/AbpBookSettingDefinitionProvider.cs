using Volo.Abp.Settings;

namespace AbpBook.Settings;

public class AbpBookSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpBookSettings.MySetting1));
    }
}
