﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicConfiguration.Core.Infrastructure
{
    public class BaseSingleton
    {
        static BaseSingleton()
        {
            AllSingletons = new Dictionary<Type, object>();
        }

        /// <summary>
        /// Dictionary of type to singleton instances.
        /// </summary>
        public static IDictionary<Type, object> AllSingletons { get; }
    }
}
