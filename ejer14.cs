using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pri, desc, prf , sd;
            Console.WriteLine("introduzca el precio del producto");
            pri = double.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el valor del descuento");
            desc = double.Parse(Console.ReadLine());
            sd = pri * desc / 100;
            prf = pri - sd;
            Console.WriteLine("Al aplicar un" + desc + " por ciento de descuento el precio final del producto es" + prf + " y por lo tanto se ahorra" + sd + "euros");
            Console.ReadLine();
            // tan solo se puede utilizar decimales con comas 
        }
    }
}
