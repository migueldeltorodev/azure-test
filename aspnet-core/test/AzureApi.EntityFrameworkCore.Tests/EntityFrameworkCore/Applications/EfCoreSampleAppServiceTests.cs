using AzureApi.Samples;
using Xunit;

namespace AzureApi.EntityFrameworkCore.Applications;

[Collection(AzureApiTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AzureApiEntityFrameworkCoreTestModule>
{

}
