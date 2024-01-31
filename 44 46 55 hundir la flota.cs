using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_46_55_hundir_la_flota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char si;
            int ejercicio = 0;
            do
            {
                Console.WriteLine("A que ejercicio desea ir?");
                ejercicio=int.Parse(Console.ReadLine());
                if(ejercicio==1)

                {
                    Random random=new Random();
                    int[,] array2d = new int[3, 3];
                    for(int i = 0; i < array2d.GetLength(0); i++)
                    {

                        for (int j = 0; j < array2d.GetLength(1); j++)
                        {
                            array2d[i, j] = random.Next(1,20);




                        }

                        
                        }
                    Console.WriteLine("Que fila quiere ver?");
                    int fila = 0;
                    fila = int.Parse(Console.ReadLine());
                    for (int i = 0; i<array2d.GetLength(1);i++)
                    {
                        Console.WriteLine(array2d[fila, i]);


                    }
                    Console.WriteLine("nuevas posiciones");
                    for(int i=0; i<array2d.GetLength(0); i++)
                    {
                        array2d[i, 3] = 0;
                        for(int j = 1; j<array2d.GetLength(1);j++)
                        {
                            Console.WriteLine(array2d[i, j]);


                        }

                    }




                }




                
                Console.WriteLine("pulse s para coninuar");
                si = char.Parse(Console.ReadLine());
                char.ToLower(si);
                Console.ReadLine();
            } while (si == 's');







        }
    }
}
