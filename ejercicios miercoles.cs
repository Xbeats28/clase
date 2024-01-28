using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cont;

            do
            {
                int ejer;
                Console.WriteLine("a que ejercicio desea ir");
                ejer=int.Parse(Console.ReadLine());
                if(ejer==31)
                {
                    int n;
                    Console.WriteLine("introduzca el valor del array");
                  n=int.Parse(Console.ReadLine());
                    double[] array = new double [n];
                    //a
                    Random random = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                       

                        array[i] = random.Next(-20, -1);
                    }

                    for (int o = array.Length - 5; o < array.Length; o++)
                    {

                        

                        array[o] = random.Next(1,20);
                    }
                    for (int a2 = 0; a2 < 5; a2++)
                    {
                        
                       
                        array[a2] = random.Next(1,20);
                    }
                    Console.WriteLine(array[1] + array[array.Length - 1]);
                    double[] copia = new double[n];
                    for(int i = 0; i < copia.Length;i++)
                    {
                        copia[i] = array[i];
                    }
                    for (int i = 0; i < copia.Length-1; i++)
                    {
                        if (copia[i] > copia[i+1])
                        {
                            double pos = copia[i+1];
                            copia[i] = copia[i+1];
                            copia[i] = pos;
                            
                        }
                    }
                    for (int i = 0; i < copia.Length; i++)
                    {
                        Console.WriteLine(copia[i]);
                    }














                                       }
                Console.ReadLine();

                Console.WriteLine("pulse 's' para continuar");
                cont=char.Parse(Console.ReadLine());

            } while (cont == 's');



        }
    }
}
