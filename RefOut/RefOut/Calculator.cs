using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RefOut
{
    class Calculator
    {
        /* REF
        public static void Triple(ref int x)
        {
            x *= 3;
        }
        */


        // OUT
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
