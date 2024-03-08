using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {

                list.Add(random.Next(1, 25));

            }
            foreach (int i in list) { Console.Write(i + " "); }

            Console.WriteLine();

            if (list.Contains(2))
            {
                Console.WriteLine("la posicion del 2 es" + list.IndexOf(2));



            }
            else { Console.WriteLine("no contiene 2"); }



            int suma = 0;
            foreach (int i in list) { suma = suma + i; }
            Console.WriteLine("la suma de todos los valores generados es " + suma);

            float media;
            media = suma / list.Count;
            Console.WriteLine("La media es de " + media);


            int contador = 0;
            foreach (int i in list)
            {
                if (i < 20)
                { contador++; }
            }
            double porcentje = 0;
            porcentje = contador * list.Count / 100;
            Console.WriteLine("el porcentaje de numeros mayo a 20 es " + porcentje + "%");



            HashSet<int> set = new HashSet<int>(list);
            Console.WriteLine("Escrito sin repeticiones");
            foreach (int i in set) { Console.Write(i + " "); }
            char salir = ' ';
            do { 
            int caso = 0;
            Console.WriteLine("**************************");
            Console.WriteLine("1 introducir tarea");
            Console.WriteLine("2 completar tarea");
            Console.WriteLine("3 contar tareas pendientes");
            Console.WriteLine("4 mostras tareas pendientes");
            Console.WriteLine("5 mostrar tareas completadas");
            Console.WriteLine("6 salir");
            caso = int.Parse(Console.ReadLine());
            List<string> tareas = new List<string>();
            List<string> tareascompletadas = new List<string>();
            if(caso == 1)
            {
               Console.ForegroundColor= ConsoleColor.Green;
                Console.Write("cargando... ");

                for (int i = 0; i < 101; i=i+10) { Console.Write(i+"%" + " "); }
                Console.WriteLine();
                Console.WriteLine("que tarea desea introducir");
                Console.ForegroundColor = ConsoleColor.White;
                string tareaintroducida = Console.ReadLine();
                tareas.Add(tareaintroducida);
            }


                if (caso == 2)

                {
                    int contador1 = 0;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("cargando... ");

                    for (int i = 0; i < 101; i = i + 10) { Console.Write(i + "%" + " "); }
                    Console.WriteLine();
                    Console.WriteLine("que tarea has completado?");
                    string tarc = Console.ReadLine();
                    tareascompletadas.Add(tarc);
                    foreach (string s in tareas)
                    {

                        if (s == tarc)
                        {

                            tareascompletadas.Add(tarc);
                            tareas[contador1] = "*";

                        }
                        contador1++;
                    }
                }
                    
                    if (caso == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("cargando... ");

                        for (int i = 0; i < 101; i = i + 10) { Console.Write(i + "%" + " "); }
                        Console.WriteLine();
                        int contador2 = 0;
                        foreach (string s in tareas)
                        {
                            if (s != "*")
                            { contador2++; }


                        }
                    Console.WriteLine("quedan unas " + contador  + " tareas");

                    }
                    if(caso==4)
                {
                    foreach (string s in tareas) { Console.WriteLine(s); }
                }
                if (caso == 5)
                {
                    foreach (string s in tareascompletadas) { Console.WriteLine(s); }
                }

                if (caso == 6) { salir = 's'; }
                


            } while (salir != 's');
            Console.ReadLine();



        }
    }
}