using Volo.Abp.Modularity;

namespace AzureApi;

public abstract class AzureApiApplicationTestBase<TStartupModule> : AzureApiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
