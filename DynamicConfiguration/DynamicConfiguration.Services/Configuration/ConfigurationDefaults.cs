using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicConfiguration.Services.Configuration
{
    public class ConfigurationDefaults
    {
        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static string SettingsAllCacheKey => "Boyner.setting.all";

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string SettingsPrefixCacheKey => "Boyner.setting.";
    }
}
