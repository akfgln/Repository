﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicConfiguration.Core.Caching
{
   public class CachingDefaults
    {
        /// <summary>
        /// Gets the default cache time in minutes
        /// </summary>
        public static int CacheTime => 60;

        /// <summary>
        /// Gets the key used to store the protection key list to Redis (used with the PersistDataProtectionKeysToRedis option enabled)
        /// </summary>
        public static string RedisDataProtectionKey => "Boyner.DataProtectionKeys";
    }
}
