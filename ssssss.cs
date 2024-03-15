using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            int ejercicio = 0;
            Console.WriteLine("a que ejercicio quiere ir");
            ejercicio = int.Parse(Console.ReadLine());
            if (ejercicio == 1)
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
            }

            if (ejercicio == 2)
            {
                char salir = ' ';
                List<string> tareas = new List<string>();
                List<string> tareas1 = new List<string>(tareas);
                List<string> tareascompletadas = new List<string>();


                do
                {
                    int caso = 0;
                    Console.WriteLine("**************************");
                    Console.WriteLine("1 introducir tarea");
                    Console.WriteLine("2 completar tarea");
                    Console.WriteLine("3 contar tareas pendientes");
                    Console.WriteLine("4 mostras tareas pendientes");
                    Console.WriteLine("5 mostrar tareas completadas");
                    Console.WriteLine("6 salir");
                    caso = int.Parse(Console.ReadLine());

                    if (caso == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("cargando... ");

                        for (int i = 0; i < 101; i = i + 10) { Console.Write(i + "%" + " "); }
                        Console.WriteLine();
                        Console.WriteLine("que tarea desea introducir");
                        Console.ForegroundColor = ConsoleColor.White;
                        string tareaintroducida = Console.ReadLine();
                        tareas.Add(tareaintroducida);
                        Console.WriteLine();
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
                        tareas.Remove(tarc);
                        Console.WriteLine("tarea completada");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
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
                            if (s != null)
                            { contador2++; }



                        }
                        Console.WriteLine("quedan unas " + contador2 + " tareas");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }
                    if (caso == 4)
                    {
                        Console.Write("cargando... ");

                        for (int i = 0; i < 101; i = i + 10) { Console.Write(i + "%" + " "); }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (string s in tareas) { Console.WriteLine(s); }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }
                    if (caso == 5)
                    {
                        Console.Write("cargando... ");

                        for (int i = 0; i < 101; i = i + 10) { Console.Write(i + "%" + " "); }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (string s in tareascompletadas) { Console.WriteLine(s); }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }

                    if (caso == 6)
                    {
                        Console.WriteLine("Bye Bye");
                        salir = 's';
                    }



                } while (salir != 's');
            }
            if (ejercicio == 3)
            {
                char cont = ' ';
                do
                {
                    int op = 0;
                    HashSet<string> dni = new HashSet<string>();
                    Console.WriteLine("1 introducir dni");
                    Console.WriteLine("2 eliminar dni");
                    Console.WriteLine("mostrar dni");
                    Console.WriteLine("buscas dni");
                    Console.WriteLine("contar dni");
                    Console.WriteLine("salir");
                    op = int.Parse(Console.ReadLine());


                    if (op == 1)
                    {
                        Console.Write("introduzca el dni:");
                        dni.Add(Console.ReadLine());
                        Console.WriteLine();
                    }
                    if (op == 2)
                    {
                        string dniborrado;
                        Console.Write("Introduzca el Dni que desea borrar");
                        dniborrado = Console.ReadLine();
                        dni.Remove(dniborrado);

                    }
                    if (op == 3)
                    {
                        foreach (string s in dni) { Console.WriteLine(s); }

                    }
                    if (op == 4)
                    {
                        string dnibuscado;
                        Console.Write("introduza el dni o parte del dni a buscar");
                        dnibuscado = Console.ReadLine();
                        foreach (string s in dni)
                        {

                            if (s.Contains(dnibuscado))
                                Console.WriteLine(s);
                        }
                    }


                    if (op == 5)
                    {
                        int contador = 0;
                        foreach (string s in dni) { if (s != null) { contador++; } Console.WriteLine(contador); }
                    }
                    if (op == 6) { cont = 's'; }



                } while (cont == ' ');

            }
            if (ejercicio == 4)
            {
                char cont = ' ';
                SortedSet<string> capital = new SortedSet<string>();
                capital.Add("Alabama Montgomery");
                capital.Add("Alaska Juneau");
                do
                {
                    int op = 0;
                    Console.WriteLine("1 buscar capital de un estado");
                    Console.WriteLine("2 mostrar estado de capital");
                    Console.WriteLine("3 introducir estado mas capital");
                    Console.WriteLine("4 mostar todos los estados ordenados alfabeticamente");
                    Console.WriteLine("5 eliminar el estado junto a su capital");
                    Console.WriteLine("Salir");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Boolean comprobador = true;
                        string capitalbuscada;
                        Console.WriteLine("introduzca el estado del cual quiere saber su capital");
                        capitalbuscada = Console.ReadLine();
                        foreach (string s in capital)
                        {
                            if (s.Contains(capitalbuscada)) { Console.WriteLine(s); comprobador = false; }

                        }
                        if (comprobador) { Console.WriteLine("no esta registrada"); }


                    }
                    if (op == 2)
                    {
                        Boolean comprobador = true;
                        string estadobuscado;
                        Console.WriteLine("introduzca la capital del cual quiere saber su estado");
                        estadobuscado = Console.ReadLine();
                        foreach (string s in capital)
                        {
                            if (s.Contains(estadobuscado)) { Console.WriteLine(s); comprobador = false; }

                        }
                        if (comprobador) { Console.WriteLine("no esta registrada"); }


                    }
                    if (op == 3)
                    {
                        Console.WriteLine("Introduce el nuevo estado y nueva capital");
                        capital.Add(Console.ReadLine());
                    }
                    if (op == 4)
                    {
                        foreach (string s in capital)
                        {
                            Console.WriteLine(s);
                        }


                    }
                    if (op == 5)
                    {
                        string eliminar;
                        Console.WriteLine("introduzca el estado y capital que desa eliminar separados por un espacio");
                        eliminar = Console.ReadLine();
                        foreach (string s in capital)
                        {
                            if (s == eliminar) { capital.Remove(eliminar); }

                        }
                    }
                    if (op == 6) { cont = 's'; }
                } while (cont != null);
            }
            if(ejercicio==5)
            {



            }


            Console.ReadLine();




        }
    }
}