using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics.Enums
{
    [Flags]
    public enum Permission : byte
    {
        Write = 1,
        Read = 2,
        Delete = 4,
        Execute = 8
        
    }
}
