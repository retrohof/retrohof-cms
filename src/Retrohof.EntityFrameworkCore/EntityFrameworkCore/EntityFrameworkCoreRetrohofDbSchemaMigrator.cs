﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Retrohof.Data;
using Volo.Abp.DependencyInjection;

namespace Retrohof.EntityFrameworkCore;

public class EntityFrameworkCoreRetrohofDbSchemaMigrator
    : IRetrohofDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreRetrohofDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the RetrohofDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RetrohofDbContext>()
            .Database
            .MigrateAsync();
    }
}
