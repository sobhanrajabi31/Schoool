using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess
{
    public enum Framework { EF, AdoNET, OnMemory}
    public sealed class DbFramework
    {
        public static Framework Framework { get; set; }
    }
}
