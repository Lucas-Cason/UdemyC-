using System;
using System.Globalization;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /* REF
            int a = 10;
            Calculator.Triple(ref a); // ref exige que a variável seja iniciada
            Console.WriteLine(a);
            */


            // OUT
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}