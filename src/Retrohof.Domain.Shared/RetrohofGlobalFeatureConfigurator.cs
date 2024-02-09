﻿using Volo.Abp.GlobalFeatures;
using Volo.Abp.Threading;

namespace Retrohof;

public static class RetrohofGlobalFeatureConfigurator
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
            GlobalFeatureManager.Instance.Modules.CmsKit(cmsKit =>
            {
                cmsKit.EnableAll();
            });
        });
    }
}
