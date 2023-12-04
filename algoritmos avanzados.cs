using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmos_avanzados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo que indica si dos arrays son iguales, estos tienen mismo tamaño y mismos valores

            Console.WriteLine("introduzca cuantas posiciones tendra el array");
            int valor1 = 0;
                valor1=int.Parse(Console.ReadLine());
            int[] r = new int[valor1] ;
            Console.WriteLine("introduzca cuantas posiciones tendra el array");
            int valor2 = 0;
            valor2 = int.Parse(Console.ReadLine());
            int[] lo = new int[valor2];
            
            
            int p1, p2, p3;
            Console.WriteLine("introduzca el valor de la posicion 1");
            p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el valor de la posicion 1");
            p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el valor de la posicion 1");
            p3 = int.Parse(Console.ReadLine());

            r[0] = p1;
            r[1] = p2;
            r[2] = p3;
            for(int i =2; i< r.Length; i++)
            {
                r[i] = r[2] + i;
            }


            int p1l, p2l, p3l;
            Console.WriteLine("introduzca el valor de la posicion 1");
            p1l = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el valor de la posicion 1");
            p2l = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el valor de la posicion 1");
            p3l = int.Parse(Console.ReadLine());

            lo[0] = p1l;
            lo[1] = p2l;
            lo[2] = p3l;

            for (int i = 2; i < r.Length; i++)
            {
                lo[i] = lo[2] + i;
                r[i] = r[2] + i;

            }
            if (r == lo) { Console.WriteLine("son iguales"); }
            else { Console.WriteLine("no son iguales"); }


            Console.ReadLine();
          
            
            //algorimo que obtiene la posicion del primer numero superior a la media del array


            //algoritmo que obtiene el numero mas pequeño de un array










        }
    }
}
