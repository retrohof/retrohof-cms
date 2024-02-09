using Volo.Abp.Settings;

namespace Retrohof.Settings;

public class RetrohofSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(RetrohofSettings.MySetting1));
    }
}
