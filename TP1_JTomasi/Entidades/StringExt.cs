using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExt
    {
        public static bool In(this string source, params string[] operadores)
        {
            foreach (string item in operadores)
                if (item == source)
                    return true;
            return false;
        }
    }
}
