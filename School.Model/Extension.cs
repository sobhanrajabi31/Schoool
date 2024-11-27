using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public static class Extension
    {
        public static int Parse(this string text)
        {
            int number;
            int.TryParse(text, out number);

            return number;
        }

        public static bool TryParse(this string text)
        {
            int number;
            return int.TryParse(text, out number);
        }
    }
}
