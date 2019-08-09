using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicConfiguration.Core
{
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public int Id { get; set; }
    }
}
