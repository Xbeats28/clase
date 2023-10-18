using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_18_del_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejer;
            Console.WriteLine("a que ejercicio quieres ir");
            ejer = int.Parse(Console.ReadLine());
            if (ejer == 4)
            {
                Console.WriteLine("dame las notas de tus examenes y calculare su media");
                int a, b, c;
                Console.WriteLine(" primer examen");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("segundo examen");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("tercer examen");
                c = int.Parse(Console.ReadLine());
                double media;
                media = a * b * c / 3;
                if (media >= 5) { Console.WriteLine("Lo lograste, estas dentro de la media" + media); }
                else
                { Console.WriteLine("lo siento no estas dentro de la media" + media); }
                Console.ReadLine();







            }
            else if (ejer == 5)
            {
                double a, b, result;
                Console.WriteLine("introduzca un numero");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("introduza otro numero");
                b = double.Parse(Console.ReadLine());
                result = Math.Sqrt(a + b);
                if (result > 0) { Console.WriteLine("El numero es positivo" + result); }
                else if (result < 0) { Console.WriteLine("El numero es negativo" + result); }

                else if (result == 0) { Console.WriteLine("El numero es neutro" + result); }
                Console.ReadLine();










            }
            else if (ejer == 6)
            {
                double num1, num2, res;
                Console.WriteLine("escibe un numero");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("escribe un numero");
                num2 = double.Parse(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine(Math.Pow(num1, num2));
                }
                else if (num1 < num2)
                {
                    Console.WriteLine(Math.Pow(num2, num1));

                }
                else if (num2 == num1) { Console.WriteLine(Math.Pow(num1, num2)); }
                else if (ejer == 8)
                      { }
                


            }
        }
    }

    }


