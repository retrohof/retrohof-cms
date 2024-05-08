using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace AgileCms.AspNetCore.Mvc.UI.Theme.Canvas.Toolbars;

public class CanvasThemeMainTopToolbarContributor : IToolbarContributor
{
    public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name != StandardToolbars.Main)
        {
            return;
        }

        if (!(context.Theme is CanvasTheme))
        {
            return;
        }

        //var languageProvider = context.ServiceProvider.GetService<ILanguageProvider>();

        //var languages = await languageProvider.GetLanguagesAsync();
        //if (languages.Count > 1)
        //{
        //    context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitchViewComponent)));
        //}

        //if (context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
        //{
        //    context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuViewComponent)));
        //}
    }
}
