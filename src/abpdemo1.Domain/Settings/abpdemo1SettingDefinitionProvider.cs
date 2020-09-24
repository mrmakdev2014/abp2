using Volo.Abp.Settings;

namespace abpdemo1.Settings
{
    public class abpdemo1SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(abpdemo1Settings.MySetting1));
        }
    }
}
