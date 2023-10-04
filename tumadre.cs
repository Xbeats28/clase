using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double espacio, tiempo, velocidad;
            Console.WriteLine("cual es el espacio que recorre el objeto");
            espacio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("en cuanto tiempo lo recorre");
            tiempo = Convert.ToDouble(Console.ReadLine());
            velocidad = espacio / tiempo;
            Console.WriteLine("la velocidad del objeto es" + velocidad + "metros/segundo");
            Console.ReadLine(); 
            

        }
    }
}
