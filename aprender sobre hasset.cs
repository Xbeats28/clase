using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //utilizando hashset ordena
            HashSet<string> set1 = new HashSet<string>();
            set1.Add("12345678");
            set1.Add("11111111u");
            set1.Add("22222222s");



            //metodos comunes
            //devolver true si contiene
            bool encontrar = set1.Contains("11111111u");
            //quitar lo que contenga
            set1.Remove("12345678");
            int elemento=set1.Count();

            //como recorrer un conjunto
            foreach(string s in set1) {
                Console.WriteLine(s);           
            }
            ISet<int> enteros = new SortedSet<int>();
            //llenar con numeros aleatoriis
            Random gen=new Random();
            for(int i=0;i<20;i++)
            {
                enteros.Add(gen.Next(1,6));
            }
            //eliminar duplicados en la lista
            List<int> list = new List<int>();
            for(int i  = 0;i<20;i++)
            {
                list.Add(gen.Next(1,6));



            }
            HashSet<int> set = new HashSet<int>(list);

            foreach(int i in set) {
                Console.Write(i + " ");
            }
            Console.ReadLine();

        }
    }
}
