using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba el lado del cuadrado");
            double lado, area, perametro, digonal;
          lado= double.Parse(Console.ReadLine());
            int y;
            y = 2;
            area = Math.Pow(lado, y);
            Console.WriteLine("area=" +  area);
            perametro = lado + lado + lado + lado;
            Console.WriteLine("perimetro=" + perametro);
            digonal = lado * Math.Sqrt(2);
            Console.WriteLine("diagonal=" + digonal);
            Console.ReadLine();
        }
    }
}
