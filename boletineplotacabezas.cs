using System;
using System.Collections.Generic;
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
                        //EJER==6==CODIGO COPIADO LO SIENTO RAMON
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
                    for (a=int.Parse(Console.ReadLine());  a <= a+5; a++)
                    {
                        for (int x = 0; x <= 3; x++)
                        {
                            Console.WriteLine(Math.Pow(a, x));
                        }
                    }

                }
            
                
                
                
                Console.ReadLine();

                Console.WriteLine("Desea continuar pulse S para seguir y N para parar");
                
                nil = Convert.ToChar(Console.ReadLine());

            }
            while (nil == 's');


        }
    }
}
