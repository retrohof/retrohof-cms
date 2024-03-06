using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using AgileCms.AspNetCore.Mvc.UI.Theme.South25.Bundling;
using AgileCms.AspNetCore.Mvc.UI.Theme.South25.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.South25;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
    )]
public class AgileCmsNetCoreMvcUISouth25ThemeModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AgileCmsNetCoreMvcUISouth25ThemeModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpThemingOptions>(options =>
        {
            options.Themes.Add<South25Theme>();

            if (options.DefaultThemeName == null)
            {
                options.DefaultThemeName = South25Theme.Name;
            }
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AgileCmsNetCoreMvcUISouth25ThemeModule>("AgileCms.AspNetCore.Mvc.UI.Theme.South25");
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new South25ThemeMainTopToolbarContributor());
        });

        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(South25ThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Styles.Global)
                        .AddContributors(typeof(South25ThemeGlobalStyleContributor));
                });

            options
                .ScriptBundles
                .Add(South25ThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Scripts.Global)
                        .AddContributors(typeof(South25ThemeGlobalScriptContributor));
                });
        });
    }
}
