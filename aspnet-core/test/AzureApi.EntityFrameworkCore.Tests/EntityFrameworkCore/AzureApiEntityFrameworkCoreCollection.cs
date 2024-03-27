using Xunit;

namespace AzureApi.EntityFrameworkCore;

[CollectionDefinition(AzureApiTestConsts.CollectionDefinitionName)]
public class AzureApiEntityFrameworkCoreCollection : ICollectionFixture<AzureApiEntityFrameworkCoreFixture>
{

}
