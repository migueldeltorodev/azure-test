using Volo.Abp.Modularity;

namespace AzureApi;

/* Inherit from this class for your domain layer tests. */
public abstract class AzureApiDomainTestBase<TStartupModule> : AzureApiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
