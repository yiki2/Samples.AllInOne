﻿using Volo.Abp.Settings;

namespace Sige.IoT.Admin.Settings
{
    public class AdminSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AdminSettings.MySetting1));
        }
    }
}