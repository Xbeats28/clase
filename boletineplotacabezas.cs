using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletin_ni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char nil;
            Console.ForegroundColor = ConsoleColor.Green;
            do

            {
                Console.WriteLine("A que ejercicio quieres ir?");
                double ejer;
                ejer = Convert.ToDouble(Console.ReadLine());
                if (ejer == 5)
                {
                    double n, ni;
                    n = 320;
                    ni = 160;
                    while (n > 160)
                    {
                        n = n - 20;
                        Console.WriteLine(n);
                    }


                }
                else if (ejer == 6)
                {
                    int nie = 0;
                    for (; nie < 100; nie++) ;
                    if (nie % 5 == 0 || nie % 7 == 0)
                    {
                        Console.WriteLine(nie);
                        
                    }



                }
                else if (ejer == 7)

                {
                    int num;
                    Console.WriteLine("iNTRODUZCA UN NUMERO DEL 1 AL 10");
                    num = int.Parse(Console.ReadLine());
                    double multi = 0;
                    if (num <= 10)
                    {
                        for (int x = 0; x <= 10; x++)
                        {
                            multi = x * num;
                            Console.WriteLine(multi + " ");
                        }
                    }
                }
                else if (ejer == 8)
                {
                    Console.WriteLine("Escriba un numero");
                    int a = int.Parse(Console.ReadLine());
                    for (; a <= a + 5; a++)
                    {

                        Console.WriteLine(Math.Pow(a, 1));
                        Console.WriteLine(Math.Pow(a, 2));
                        Console.WriteLine(Math.Pow(a, 3));
                    }

                }
                else if (ejer == 9)
                {
                    Console.WriteLine("Raiz de 16 y sus restantes -2.5");

                    for (double n = 16; n >= 1;)
                    {
                        Console.WriteLine(Math.Sqrt(n));
                        n = n - 2.5;
                    }
                }
                else if (ejer == 10)
                {
                    Console.WriteLine("Introduzca un valor positivo");
                    double o = Convert.ToDouble(Console.ReadLine());
                    if (o > 0)
                    {
                        for (int i = 0; i <= 10; i++)
                        {

                            Console.WriteLine(o + i);
                        }
                    }
                    else { Console.WriteLine("Uno positivo dije"); }



                }
                else if (ejer == 11)
                {
                    double n, i, l, e;

                    Console.WriteLine("Esciba un numero positivo");
                    i = double.Parse(Console.ReadLine());
                    for (n = 1; n <= i; n++)
                    {
                        l = 1 / Math.Pow(n, 3);
                        Console.WriteLine(l);
                    }
                }
                else if (ejer == 12)
                    Console.WriteLine("Introduzca un numero positivo");
                double li = Convert.ToDouble(Console.ReadLine());
                // salir prematuramenet de un bucle --> sentencia break
                // encontrar el primer multiplo de 3,7 y 8 a la  vez en un rango
                int limiinf = 1200;
                int suma2 = 0;
                int limitsup = 3500;
                for ( int i = limiinf; i <= limitsup; i++)
                {
                    if (i % 3 == 0 && i % 7 == 0 && i % 8 == 0)
                    {
                        continue;
                    }
                    suma2 = suma2 + i;
                    

                }


                
                
                
                
                
                
                Console.ReadLine();

                Console.WriteLine("Desea continuar pulse S para seguir y N para parar");
                
                nil = Convert.ToChar(Console.ReadLine());

            }
            while (nil == 's');


        }
    }
}
