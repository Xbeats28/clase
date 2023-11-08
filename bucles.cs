using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, o;
            i = 25;
                o = 120;
            i = o;
            int contador = 0;
            //inicialiazo la variable de control
            Console.WriteLine("Valores entre "+o + "y "+i);
            //bucle for
            //mostrar numeros entre 1 y 20 por pantalla
            for (int a = 1; a <= 20; a = a + 1)
                Console.WriteLine(a);
            //calcular la suma de todos los nmeros entre n y m
            Console.WriteLine("a");
            int n = 15;
                int m = 30;
            int suma = 0;
            for (int y =n; y<=30; y++) { suma = suma + y; Console.WriteLine(suma); }
            //calcular la suma de los numeros impares entre n y m
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            n = 15;
            m = 30;
            suma = 0;
            for (int y = n; y <= 30; y++)
            { if (y % 2 != 0) 
                { suma = suma + y; Console.WriteLine(suma); }
            }

            Console.ReadLine();

           
        }
    }
}
