using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varios_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program que claifique un numero como negaivo cero  o posiivo
            int a;
            Console.WriteLine("numero");
            a = int.Parse(Console.ReadLine());
            if (a % 3 ==0 && a % 5==0)
            {
                Console.WriteLine(" es divisible entre ambod");
            }
            else if( a % 3 ==0)
            {
                Console.WriteLine("es multiplo de 3");

            }
            else if(a %5 == 0)
            {
                Console.WriteLine("es multiplo de 5");
            }
            Console.ReadLine();





           
        
        
            
        }
    }
}
