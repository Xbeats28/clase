using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_15_17_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double ejer = 0;

            char si;
            do
            {
                Console.WriteLine("a que ejercicio desea ir");


                ejer = double.Parse(Console.ReadLine());

                if (ejer == 14)
                {
                    double[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    double suma = 0;
                    for (int i = 0; i < num.Length; i++)
                    {
                        suma = suma + Math.Pow(num[i], 2);
                        if (i == num.Length)
                        { Console.WriteLine(suma); }

                    }

                }

                if (ejer == 15)
                {
                    double[] nmr = new double[15];
                    double suma2 = 0;
                    Random generador = new Random();
                    for (int i = 0; i < nmr.Length; i++)
                    {

                        nmr[i] = generador.Next();
                        if (nmr[i] == 0 || nmr[i] > 0)
                        {
                            suma2 = suma2 + nmr[i];
                            Console.WriteLine(suma2);
                        }

                    }
                }

                if (ejer == 17)
                {

                    double[] nmr2 = new double[15];
                    double suma3 = 0;
                    Random generado2r = new Random();
                    for (int i = 0; i < nmr2.Length; i++)
                    {

                        nmr2[i] = generado2r.Next();

                        if (nmr2[i] % 2 != 0)
                        {
                            suma3++;
                            Console.WriteLine(suma3 / 100 * 15);
                        }

                    }
                }
                if (ejer == 26)
                {
                    int i = 0;
                    i++;
                    double[] ikenna = new double[5];
                    double[] obama = new double[5];
                    bool sex = true;

                    for (int z = 0; z < 5; z++)
                    {


                        Console.WriteLine("escriba los valores del array");
                        ikenna[i] = double.Parse(Console.ReadLine());


                        Console.WriteLine("escriba los valores del array");
                        obama[i] = double.Parse(Console.ReadLine());

                    }

                    for (i = 0; i < ikenna.Length; i++)
                    {

                        if (ikenna[i] != obama[i])
                        {

                            sex = false;

                            if (sex == false)
                            {

                                Console.WriteLine("Las dos arrays son distintas");

                            }
                            break;
                        }

                    }
                    if (sex == true)
                    {

                        Console.WriteLine("Las dos arrays son iguales");

                    }
                }


                else if (ejer == 1)
                {



                    double[] nmr2 = new double[5];
                    double suma3 = 0;
                    for (int o = 0; o < nmr2.Length; o++)
                    {
                        Console.WriteLine("escriba los valores de la array");
                        nmr2[o] = double.Parse(Console.ReadLine());
                    }
                    for (int o = 0; o < nmr2.Length; o++)
                    {

                        suma3 += nmr2[o];
                        if (o == nmr2.Length)
                        {
                            suma3 = suma3 / 5;
                            for (int j = 0; j <= nmr2.Length; j++)
                            {
                                if (nmr2[j] > suma3)
                                {
                                    Console.WriteLine(nmr2[o]);
                                }
                            }
                        }


                    }


                }
                else if (ejer == 2)
                {


                    int[] matriz = { 2, 25, 3, 1, 5 };
                    for (int k = 0; k < matriz.Length; k++)
                    {
                        for (int i = 0; i < matriz.Length - 1; i++)
                        {
                            if (matriz[i] > matriz[i + 1])
                            {

                                int aux = matriz[i];

                                matriz[i] = matriz[i + 1];
                                Console.WriteLine(matriz[i]);
                            }

                        }
                    }
                }

                    Console.WriteLine("pulse 's' para continuar");
                    si = char.Parse(Console.ReadLine());
                    Console.ReadLine();

                } while (si == 's') ;


            }
    }
}
