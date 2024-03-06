using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using AgileCms.AspNetCore.Mvc.UI.Theme.Mdw.Bundling;
using AgileCms.AspNetCore.Mvc.UI.Theme.Mdw.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Mdw;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
    )]
public class AgileCmsNetCoreMvcUIMdwThemeModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AgileCmsNetCoreMvcUIMdwThemeModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpThemingOptions>(options =>
        {
            options.Themes.Add<MdwTheme>();

            if (options.DefaultThemeName == null)
            {
                options.DefaultThemeName = MdwTheme.Name;
            }
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AgileCmsNetCoreMvcUIMdwThemeModule>("AgileCms.AspNetCore.Mvc.UI.Theme.Mdw");
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new MdwThemeMainTopToolbarContributor());
        });

        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(MdwThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Styles.Global)
                        .AddContributors(typeof(MdwThemeGlobalStyleContributor));
                });

            options
                .ScriptBundles
                .Add(MdwThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Scripts.Global)
                        .AddContributors(typeof(MdwThemeGlobalScriptContributor));
                });
        });
    }
}
