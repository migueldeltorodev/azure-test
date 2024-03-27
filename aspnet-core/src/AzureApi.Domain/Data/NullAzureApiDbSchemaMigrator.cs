using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AzureApi.Data;

/* This is used if database provider does't define
 * IAzureApiDbSchemaMigrator implementation.
 */
public class NullAzureApiDbSchemaMigrator : IAzureApiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
