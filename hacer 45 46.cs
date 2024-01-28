using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char si;
            do
            {
                Console.WriteLine("Ejercicio?");
                int ejercicio = 0;
                
                ejercicio=int.Parse(Console.ReadLine());
                switch (ejercicio)
                {
                    case 1:
                        double[,] ikenna = new double[3, 3];
                        Random random = new Random();


                        for (int i = 0; i < ikenna.GetLength(0); i++)
                        {
                            for (int j = 0; j < ikenna.GetLength(1); j++)
                            {

                                ikenna[i, j] = random.Next(-20, 40);
                            }

                        }
                        Console.WriteLine("A que fila quiere ir?");
                        int response = 0;
                        response = int.Parse(Console.ReadLine());
                        for (int i = 0; i < ikenna.GetLength(1); i++)
                        {
                            Console.WriteLine(ikenna[response, i]);

                        }
                        Console.WriteLine("guardar un cero en la ultima posicion, esta es la lista actual");
                        
                        
                        
                        for (int i = 0;i < ikenna.GetLength(0);i++)
                        {
                            for (int j = 0; j < ikenna.GetLength(1); j++)
                            {

                                Console.WriteLine(ikenna[i, i]);
                            }
                        }

                        for(int i =0; i< ikenna.GetLength(0); i++)
                        {
                            ikenna[i, 2] = 0;


                        }
                        Console.WriteLine("la nueva lista es");
                        for(int i = 0; i <ikenna.GetLength(0); i ++)
                        {
                            
                            for(int j = 0; j< ikenna.GetLength (1); j++)
                            {
                                
                                Console.WriteLine(ikenna[i, j]);
                            }


                        }

                        double suma = 0;
                        for (int i =0; i< ikenna.GetLength(1);i++)
                        {
                            suma = suma + ikenna[0,i];


                        }
                        Console.WriteLine("la suma de todos los valores de la primeraffila es " + suma);


                        Console.WriteLine("contar cuantos ceros hay en la segunda columna");
                        int ceros = 0;
                        for (int i = 0; i < ikenna.GetLength(0);i++)
                        {
                           
                                if (ikenna[i, 1] == 0)
                                {
                                    ceros++;
                                    
                                }
                            

                        }
                        Console.WriteLine(ceros);

                        Console.WriteLine("calcular media");
                        double media = 0;
                        for (int i = 0; i< ikenna.GetLength(0); i++)
                        {
                            for(int j = 0; j< ikenna.GetLength(1); j++)
                            {

                                media = media + ikenna[i, j];
                            }
                        }
                        media = media / ikenna.Length;
                        Console.WriteLine("la media es="+Math.Round(media,2));

                        break;

                }
                Console.WriteLine("Desea continuar?");
                si = char.Parse(Console.ReadLine());
                Console.ReadLine();
            } while (si == 's');
        }
    }
}
