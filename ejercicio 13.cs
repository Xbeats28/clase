using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ca, cb, rs, a;
            Console.WriteLine("introduzca valor del cateto a");
            ca =double.Parse(Console.ReadLine());
            Console.WriteLine("indtroduzca valor del cateto b");
            cb = double.Parse(Console.ReadLine());
            int y = 2;
            rs = Math.Pow(ca,y) * Math.Pow(cb,y);
            a = Math.Sqrt(rs);
            Console.WriteLine("la hipotenuse es=" + a);
            Console.ReadLine();
        }
    }
}
