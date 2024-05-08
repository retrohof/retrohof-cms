using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using AgileCms.AspNetCore.Mvc.UI.Theme.Canvas.Bundling;
using AgileCms.AspNetCore.Mvc.UI.Theme.Canvas.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
    )]
public class AgileCmsNetCoreMvcUICanvasThemeModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AgileCmsNetCoreMvcUICanvasThemeModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpThemingOptions>(options =>
        {
            options.Themes.Add<CanvasTheme>();

            if (options.DefaultThemeName == null)
            {
                options.DefaultThemeName = CanvasTheme.Name;
            }
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AgileCmsNetCoreMvcUICanvasThemeModule>("AgileCms.AspNetCore.Mvc.UI.Theme.Canvas");
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new CanvasThemeMainTopToolbarContributor());
        });

        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(CanvasThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Styles.Global)
                        .AddContributors(typeof(CanvasThemeGlobalStyleContributor));
                });

            options
                .ScriptBundles
                .Add(CanvasThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Scripts.Global)
                        .AddContributors(typeof(CanvasThemeGlobalScriptContributor));
                });
        });
    }
}
