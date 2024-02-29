using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.TenantManagement;

namespace Retrohof.TenantManagement
{
    public interface IHostTenantRepository : IBasicRepository<Tenant, Guid>
    {
        Task<Tenant> GetTenantByHost(string host, CancellationToken cancellationToken = default);
    }

}
