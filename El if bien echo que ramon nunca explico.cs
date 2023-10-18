using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // para aprobar la asignatura hay que cumplir tres ondiciones
            //aprobar examenes, tareas, comportamiento
            int nota;
            Boolean exa;
            Boolean tar;
            Boolean comp;
            Console.WriteLine("ponga su nota");
            nota = int.Parse(Console.ReadLine());
            if (nota >= 5)
            { exa = true; }
            else { exa = false; }
            int tareas, comport;
            Console.WriteLine("introuzca si hizo todas las tareas 1 = si 0 = no");
            tareas = int.Parse(Console.ReadLine());

            if (tareas == 1) { tar = true; }
            else { tar = false; }
            Console.WriteLine("introduzca si tuvo un buen comportamiento 1 = si 0 = no");
            comport = int.Parse(Console.ReadLine());

            if (comport == 1) { comp = true; }
            else { comp = false; }
            if (tar == true && comp == true && exa == true) { Console.WriteLine("aprobado en todo"); }
            else
            {
                { Console.WriteLine("suspenso"); }

                if (exa == true) { Console.WriteLine("aprobado en examenes"); }
                else { Console.WriteLine("suspenso en examenes"); }



                if (tar == true) { Console.WriteLine(" aprobado en tareas"); }
                else { Console.WriteLine("suspenso en tareas"); }


                if (comp == true) { Console.WriteLine("aprobado en comportamiento"); }
                else { Console.WriteLine("suspenso en comportamiento"); }


                
            }
            Console.ReadLine();
        }
    }
}
