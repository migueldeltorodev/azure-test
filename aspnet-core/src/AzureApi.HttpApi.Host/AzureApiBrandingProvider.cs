using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AzureApi;

[Dependency(ReplaceServices = true)]
public class AzureApiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AzureApi";
}
