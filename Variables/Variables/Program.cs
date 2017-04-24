using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            byte b = 0;
            short c = 3000;
            long d = 900000;
            sbyte e = 127;
            ushort f = 65535;
            uint g = 666;
            ulong h = 777;
            float i = 3.1415926f;
            double dbl = 3.14159;
            decimal dec = 1.495m;
            bool truthValue = true;

            a = 0;
            b = 0;
            c = -32000;
            d = 90;
            e = 125;
                f = 65535;
                g = 6;
                h = 7;
            i = 3.1415926f;
                dbl = 3.1;
            dec = 1.4m;
            truthValue = true;


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
          Console.WriteLine(d);
           Console.WriteLine(e);
           Console.WriteLine(f);
           Console.WriteLine(g);
           Console.WriteLine(h);
           Console.WriteLine(i);
            Console.WriteLine(dbl);
            Console.WriteLine(dec);
            Console.WriteLine(truthValue);
            Console.ReadKey();
        }
    }
}
