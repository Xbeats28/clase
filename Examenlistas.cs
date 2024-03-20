using System;using System.Collections.Generic;using System.Collections.Specialized;
using System.Linq;using System.Text;using System.Threading.Tasks;namespace ConsoleApp16{    internal class Program    {        static void Main(string[] args)        {            //variables            Boolean continuar = true;            int op = 0;            //fin            do            {                Console.WriteLine("ejercicio?");                op = int.Parse(Console.ReadLine());                if (op == 1)                {                    //declaracion de variables diego fernandez lorenzo                    List<int> listd = new List<int>(20);                    Random random = new Random();                    int capacidad = 0;                    int posicioneslibres = 0;                    int pos0;                    int contador = 0;                    //fin                    for (int i = 0; i<20;i++)                    { listd.Add(random.Next(-10,10));                        Console.Write(listd[i]+" || ");                                          }                    Console.WriteLine();                    capacidad = listd.Capacity;                    posicioneslibres = capacidad - listd.Count;                    Console.WriteLine("capacidad:"+capacidad);                    Console.WriteLine("Nº POS LIBRES:"+posicioneslibres);                 if (listd.Contains(0)) //diego fernandez lorenzo//pongo la posicion en pos0                                                                //ya que dices obtener                    {                        pos0 = listd.IndexOf(0);                    Console.WriteLine(" La posicion de 0 es " +pos0);                    }                    else { Console.WriteLine("la lista no contiene ningun 0"); }                    listd[2] = 11;//diego fernandez lorenzo                                                               int a = 0;                    for(int i = 0; i<=5;i++)                    {                        a = listd[5];                        if (i == 5)                         {                            Console.WriteLine("borrando"+ a);                            listd.Remove(a);                        }                    }                    foreach (int s in listd) { Console.Write(s + " || "); }

                    int count1 = 0;                    listd.Remove(3);
                    foreach (int s in listd) { Console.Write(s + " || "); }


                    List<int> list2 = new List<int>(listd);//Diego Fernandez Lorenzo
                    Console.WriteLine("nueva lista");
                    foreach (int s in listd) { Console.Write(s + " || "); }
                    List<int> list3 = new List<int>();//Diego Fernandez Lorenzo
                    
                    foreach(int i in listd)
                    {

                        if(i<0)
                        {
                            list3.Add(i);


                        }
                     
                    }
                    foreach (int s in list3) { Console.Write(s + " || "); }
                    Console.WriteLine("sin duplicados");
                    HashSet<int> set = new HashSet<int>(listd);
                    foreach (int s in set) { Console.Write(s + " || "); }                }                Boolean igualdad;                int derechoshembra = 1;                int derechosmacho = 0;                if (derechoshembra == derechosmacho) { igualdad = true; }                else { igualdad = false; }                Console.ReadLine();            } while(continuar);        }    }}