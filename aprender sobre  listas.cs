using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {//crear una lista de enteros
            List<int> nombre = new List<int>();
            //ver la capacidad de la lista
            Console.WriteLine(nombre.Capacity);


            //insertar elementos
           
                nombre.Add(0);
                nombre.Add(1);
            nombre.Add(2);
            nombre.Add(4);
            nombre.Add(4);
                Console.WriteLine(nombre.Capacity);
            


            //insertar elemento en cierta posicion
            nombre.Insert(0, 2);
            
            //recuperar un elemento
            int primerelemento = nombre[0];

            //obtener posicion de un elemento 
            int posele = nombre.IndexOf(1);

            //ver si contiene un element
          Boolean contiene = nombre.Contains(2);


            Console.WriteLine("VER LISTA");
            foreach(int i in nombre)
            {

                Console.Write(i+" ");
            }
            //eliminar una posicion
            nombre.RemoveAt(0);

            nombre.RemoveAll(x=> x == 4);
            //recorrer una lista con foreach
            foreach(int i in nombre)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();
            //recorrer con un for
            for(int i = 0; i < nombre.Count;i++) 
            {
                Console.Write(nombre[i]+" ");
            
            
            }
            Console.WriteLine();




            Console.ReadLine();

        }
    }
}
