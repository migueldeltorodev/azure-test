using Volo.Abp.Modularity;

namespace AzureApi;

[DependsOn(
    typeof(AzureApiApplicationModule),
    typeof(AzureApiDomainTestModule)
)]
public class AzureApiApplicationTestModule : AbpModule
{

}
