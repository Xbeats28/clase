using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercic_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca el lado");
            double lado, d, a, v;
            lado = Convert.ToDouble(Console.ReadLine());
            int x, y;
            x = 2;
                y = 3;
            d = Math.Sqrt(3) * lado;
            a = 4 * Math.Pow(lado, x);
            v = Math.Pow(lado, y);
            Console.WriteLine("d=" + d + "a=" + a + "v=" + v);
            Console.ReadLine();

        }
    }
}
