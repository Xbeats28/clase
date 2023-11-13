using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte_2_boletion_9_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char si;
            do
            {
                Console.WriteLine("A que ejercicio quieres ir?");
                double ejer;
                ejer = Convert.ToDouble(Console.ReadLine());
                if (ejer == 13)
                {
                    Console.WriteLine("Introduzca un numero por teclado");
                    double num = Convert.ToDouble(Console.ReadLine());
                     
                }



                Console.WriteLine("Desea continuar? pulse s para seguir o n para parar");
                si = Convert.ToChar(Convert.ToInt32(Console.ReadLine()));
            } while (si == 's');
        }
    }
}
