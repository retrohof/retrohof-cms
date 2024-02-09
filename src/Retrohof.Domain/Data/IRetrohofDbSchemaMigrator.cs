using System.Threading.Tasks;

namespace Retrohof.Data;

public interface IRetrohofDbSchemaMigrator
{
    Task MigrateAsync();
}
