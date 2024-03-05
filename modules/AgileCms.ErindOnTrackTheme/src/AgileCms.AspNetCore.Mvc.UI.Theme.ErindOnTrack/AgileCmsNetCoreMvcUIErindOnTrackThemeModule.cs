using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack.Bundling;
using AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
    )]
public class AgileCmsNetCoreMvcUIErindOnTrackThemeModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AgileCmsNetCoreMvcUIErindOnTrackThemeModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpThemingOptions>(options =>
        {
            options.Themes.Add<ErindOnTrackTheme>();

            if (options.DefaultThemeName == null)
            {
                options.DefaultThemeName = ErindOnTrackTheme.Name;
            }
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AgileCmsNetCoreMvcUIErindOnTrackThemeModule>("AgileCms.AspNetCore.Mvc.UI.Theme.ErindOnTrack");
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new ErindOnTrackThemeMainTopToolbarContributor());
        });

        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(ErindOnTrackThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Styles.Global)
                        .AddContributors(typeof(ErindOnTrackThemeGlobalStyleContributor));
                });

            options
                .ScriptBundles
                .Add(ErindOnTrackThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Scripts.Global)
                        .AddContributors(typeof(ErindOnTrackThemeGlobalScriptContributor));
                });
        });
    }
}
