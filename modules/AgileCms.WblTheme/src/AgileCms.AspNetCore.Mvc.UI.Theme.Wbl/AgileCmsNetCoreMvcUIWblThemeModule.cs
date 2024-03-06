using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using AgileCms.AspNetCore.Mvc.UI.Theme.Wbl.Bundling;
using AgileCms.AspNetCore.Mvc.UI.Theme.Wbl.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Wbl;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
    )]
public class AgileCmsNetCoreMvcUIWblThemeModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AgileCmsNetCoreMvcUIWblThemeModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpThemingOptions>(options =>
        {
            options.Themes.Add<WblTheme>();

            if (options.DefaultThemeName == null)
            {
                options.DefaultThemeName = WblTheme.Name;
            }
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AgileCmsNetCoreMvcUIWblThemeModule>("AgileCms.AspNetCore.Mvc.UI.Theme.Wbl");
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new WblThemeMainTopToolbarContributor());
        });

        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(WblThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Styles.Global)
                        .AddContributors(typeof(WblThemeGlobalStyleContributor));
                });

            options
                .ScriptBundles
                .Add(WblThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Scripts.Global)
                        .AddContributors(typeof(WblThemeGlobalScriptContributor));
                });
        });
    }
}
