using System.Threading.Tasks;

namespace AzureApi.Data;

public interface IAzureApiDbSchemaMigrator
{
    Task MigrateAsync();
}
