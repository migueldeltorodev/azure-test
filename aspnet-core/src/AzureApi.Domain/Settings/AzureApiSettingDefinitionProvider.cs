using Volo.Abp.Settings;

namespace AzureApi.Settings;

public class AzureApiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AzureApiSettings.MySetting1));
    }
}
