using Volo.Abp.Modularity;

namespace AzureApi;

[DependsOn(
    typeof(AzureApiDomainModule),
    typeof(AzureApiTestBaseModule)
)]
public class AzureApiDomainTestModule : AbpModule
{

}
