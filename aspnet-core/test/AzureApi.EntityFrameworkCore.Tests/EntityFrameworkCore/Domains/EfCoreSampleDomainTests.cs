using AzureApi.Samples;
using Xunit;

namespace AzureApi.EntityFrameworkCore.Domains;

[Collection(AzureApiTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AzureApiEntityFrameworkCoreTestModule>
{

}
