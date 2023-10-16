using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa calsificar numero en par o impar
            int numero = 1;
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " es par");
            }
            else
            {
                Console.WriteLine(numero + " es impar");


                //programa para ver si un numero difernte a cero
                if (numero == 0)
                { Console.WriteLine(numero + "es disntto a 0"); }
                else
                { Console.WriteLine(numero + "es igual a 0"); }
                Console.ReadLine();
                // programa que a partor del salario bruto de un  trabajdor aplica un irpf del 15% si el
                // salario es mayor o igaul a 1200 19 %  si es superior
                Console.WriteLine("introduzaca su salario");
                int salario;
                int resta;
                salario = int.Parse(Console.ReadLine());
                if (salario <= 1200)
                {
                    resta = salario * 15 / 100;
                    salario = salario - resta;
                    Console.WriteLine(salario + " este es su salario");
                    
                }
                else
                {
                    resta = salario * 19 / 100;
                    salario = salario - resta;
                    Console.WriteLine(salario + "este es su salario");
                    

                    



                }



            }
        }
    }
}
