using Volo.Abp.Settings;

namespace Abp.Layers.Settings;

public class LayersSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LayersSettings.MySetting1));
    }
}
