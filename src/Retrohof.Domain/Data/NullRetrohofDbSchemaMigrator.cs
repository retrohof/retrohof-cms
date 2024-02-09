using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Retrohof.Data;

/* This is used if database provider does't define
 * IRetrohofDbSchemaMigrator implementation.
 */
public class NullRetrohofDbSchemaMigrator : IRetrohofDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
