using AzureApi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AzureApi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AzureApiEntityFrameworkCoreModule),
    typeof(AzureApiApplicationContractsModule)
    )]
public class AzureApiDbMigratorModule : AbpModule
{
}
