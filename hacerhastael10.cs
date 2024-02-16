using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace boltring
{
    internal class Program
    {
        static void Main(string[] args)
        { int ejercicio = 0;
            char si; do
            {
                
               Console.WriteLine("a que ejercicio quiere ir?");
                ejercicio=int.Parse(Console.ReadLine());
                if (ejercicio == 1)
                {
                    string[] matricula = new string[2];
                    Console.WriteLine("escriba una matricula en formato 9999-AAA(minimo 2 que acaben en z)");
                    for (int i = 0; i < matricula.Length; i++)
                    {
                        Console.WriteLine("otra");
                        matricula[i] = Console.ReadLine();

                    }
                    string[] matriculaz = matricula;

                    Console.WriteLine("contiene z");
                    for (int i = 0; i < matricula.Length; i++)
                    {

                        if (matricula[i].EndsWith("z"))
                        {
                            Console.WriteLine(matricula[i]);

                        }

                       



                    }

                    Console.WriteLine("B )");
                    Console.WriteLine("contiene 34");
                    for (int i = 0; i < matricula.Length; i++)
                    {

                        if (matricula[i].Contains("34"))
                        {
                            Console.WriteLine(matricula[i]);

                        }
                    }


                    Console.WriteLine("C )");
                    for (int i = 0; i < matricula.Length; i++)
                    {
                        Console.WriteLine(matricula[i].Substring(0, 4));
                    }

                    Console.WriteLine("d )");
                    for (int i = 0; i < matricula.Length; i++)
                    {
                        Console.WriteLine(matricula[i].Substring(5,3));
                    }

                    StreamWriter escritor = new StreamWriter(Directory.GetCurrentDirectory() + " \\matriculas.txt ", false);



                }
                else if(ejercicio==2)
                    {
                    string userwriteline;
                    Console.WriteLine("Escribe algo ");
                    userwriteline = Console.ReadLine();
                    char search;
                    Console.WriteLine("Que char quieres ver cuantas veces aparece en el string");
                    search = char.Parse(Console.ReadLine());

                    int count = 0;
                    bool prove = true;
                    for(int i = 0; i<userwriteline.Length; i++)
                    {
                        if (userwriteline[i] == search)
                        {
                         count++;

                            prove= false;
                        }


                    }
                    if (prove) { Console.WriteLine("no se ha encontrado ninguno"); }
                    else { Console.WriteLine("El caracter "+search +"Se ha encontrado una/s " + count +" veces" ); }
                }
                else if (ejercicio == 3)
                {

                    string DNI;
                    Console.WriteLine("Escriba su DNI");
                    DNI=Console.ReadLine();
                    char prover1, prover2;
                    bool prove = true;
                    int counter = 0;
                    for(int i =0; i<DNI.Length-1; i ++)
                    {
                        prover1 = DNI[i];

                        if (char.IsDigit(prover1))
                        {
                            counter++;
                            prove = false;
                        }

                    }
                    if (prove) { Console.WriteLine("Incorrecto"); }

                     if (counter != 9)
                    {
                        Console.WriteLine("Incorrecto");
                       

                    }

                    prover1 = DNI[DNI.Length-1];
                    if (char.IsDigit(prover1))
                    {
                        Console.WriteLine("Incorrecto");
                      
                    }
                 
                    char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
                    string db;
                    
                   

                    





                }
                if (ejercicio ==4)



                {

                    string b;
                    string[] b2 = new string[100];
                    Console.WriteLine("escriba algo que tenga b");
                    b = Console.ReadLine();
                 b2 = b.Split(' ');
                    for (int i = 0 ; i < b2.Length; i++)
                    {
                        if (b2[i].StartsWith("b",StringComparison.OrdinalIgnoreCase) )
                        {
                            Console.WriteLine(b2[i]);
                        }

                    }




                }
                if(ejercicio==5)
                {
                    string frase;
                    Boolean a = false;
                    Console.WriteLine("Escriba una frase");
                    frase = Console.ReadLine();
                    if (frase.Contains('@'))
                    {
                        a = true;
                        Console.WriteLine("true");
                    }
                    else { Console.WriteLine("false"); }

                }





                    Console.ReadLine();
                Console.WriteLine("pulse s para continuar");
                    si = char.Parse(Console.ReadLine());
            } while(si == 's');
            
            













        }
    }
}
