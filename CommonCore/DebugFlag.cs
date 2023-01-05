using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCore
{
    public sealed class DebugFlag
    {

        public bool IsDebug { get; set; }

        private DebugFlag()
        {
        }

        private static readonly Lazy<DebugFlag> lazy = new Lazy<DebugFlag>(() => new DebugFlag());
        
        public static DebugFlag Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
