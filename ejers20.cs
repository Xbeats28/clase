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








            }
            else if (ejer == 5)
            {
                double a, b, result;
                Console.WriteLine("introduzca un numero");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("introduza otro numero");
                b = double.Parse(Console.ReadLine());
                result = Math.Sqrt(a + b);
                if (result > 0)
                {
                    Console.WriteLine("El numero es positivo");
                    Console.ReadLine();
                }
                else if (result < 0)
                {
                    Console.WriteLine("El numero es negativo");
                    Console.ReadLine();

                }

                else if (result == 0) { Console.WriteLine("El numero es neutro"); }
            }

            else if (ejer == 8)
            {
                Console.WriteLine("cual es la presion");
                int presion, temp;
                presion = int.Parse(Console.ReadLine());
                Console.WriteLine("cual es la temperatura en kelvins");
                temp = int.Parse(Console.ReadLine());
                if (presion > 2 && temp > 500) { Console.WriteLine("evacuar edificio "); }
                else if (presion > 2) { Console.WriteLine("Abrir valvula de emergencia"); }
                else if (temp > 500) { Console.WriteLine("bajar temperatura"); }
                else { Console.WriteLine("todo esta en orden"); }
            }
            else if (ejer == 6)
            {
                int b = 1234;
                Console.WriteLine("escriba su contraseña");
                int contra = int.Parse(Console.ReadLine());

                if (b == contra)
                {
                    Console.WriteLine("la contraseña es correcta");
                }
                else { Console.WriteLine("la contraseña es incorrecta"); }
            }
            else if (ejer == 7)
            {
                Console.WriteLine("introduzca un numero");
                double a, b;
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("introduzca otro");
                b = double.Parse(Console.ReadLine());
                if (a > b)
                    Console.WriteLine(Math.Pow(a, b));
                else { Console.WriteLine(Math.Pow(b, a)); }




            }
            Console.ReadLine();









        }

    }











}




