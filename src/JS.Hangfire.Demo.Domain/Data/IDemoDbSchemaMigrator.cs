using System.Threading.Tasks;

namespace JS.Hangfire.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
