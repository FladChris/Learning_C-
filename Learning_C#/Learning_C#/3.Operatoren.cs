using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class Operatoren
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 10;
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);

            int g = 10;
            string f = "abc";
            string l = "abc";
            Console.WriteLine(f + l);
            Console.WriteLine(f == l);
            Console.WriteLine(g + f);
            Console.WriteLine(f + g + l);

            Console.ReadLine();
        }
    }
}
