using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicConfiguration.Core.Configuration
{
    public class Setting : BaseEntity
    {
        public Setting()
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        /// <param name="aplicationName">Aplication identifier</param>
        public Setting(string name, string value, string applicationName = null)
        {
            Name = name;
            Value = value;
            ApplicationName = applicationName;
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the store for which this setting is valid. 0 is set when the setting is for all stores
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// isActive
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>Result</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
