using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.TenantManagement;
using Volo.Abp.Threading;

namespace Retrohof.EntityFrameworkCore;

public static class RetrohofEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        RetrohofGlobalFeatureConfigurator.Configure();
        RetrohofModuleExtensionConfigurator.Configure();

        ObjectExtensionManager.Instance
            .MapEfCoreProperty<Tenant, string>(Constant.Host);
    }
}
