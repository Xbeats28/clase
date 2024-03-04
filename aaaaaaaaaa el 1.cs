using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for(int i = 0; i < 20; i++) {
               
                list.Add(random.Next(1,25));
              
            }
            foreach(int i in list) { Console.Write(i+" "); }

            Console.WriteLine();
           
            if(list.Contains(2))
            {
                Console.WriteLine("la posicion del 2 es"+list.IndexOf(2));
             


            }
            else { Console.WriteLine("no contiene 2"); }
            
            
            
            int suma = 0;
            foreach(int i in list) { suma=suma+i;}
            Console.WriteLine("la suma de todos los valores generados es " + suma);

            float media;
            media = suma / list.Count;
            Console.WriteLine("La media es de "+ media);


            int contador = 0;
            foreach(int i in list) {
                if(i<20)
                { contador++; }
            }
            double porcentje = 0;
            porcentje = contador * list.Count / 100;
            Console.WriteLine("el porcentaje de numeros mayo a 20 es "+porcentje+"%");
           
            
            
            HashSet<int> set = new HashSet<int>(list);
            Console.WriteLine("Escrito sin repeticiones");
            foreach(int i in set) {Console.Write(i+" ");}

            Console.ReadLine();

        }
    }
}
