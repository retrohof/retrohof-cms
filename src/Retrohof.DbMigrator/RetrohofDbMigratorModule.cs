using Retrohof.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Retrohof.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RetrohofEntityFrameworkCoreModule),
    typeof(RetrohofApplicationContractsModule)
    )]
public class RetrohofDbMigratorModule : AbpModule
{
}
