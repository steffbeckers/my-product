using Volo.Abp.Settings;

namespace SteffBeckers.MyProduct.Settings;

public class MyProductSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyProductSettings.MySetting1));
    }
}
