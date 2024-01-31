using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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




                    // Especificar el delimitador (coma en este caso)
                    char[] delimitador = new char[2];
                    delimitador[1]= '-';
                    // Dividir la cadena en subcadenas usando el delimitador
                    string[] subcadenas = new string[10];
                   
                    // Imprimir las subcadenas resultantes
                    foreach (string subcadena in subcadenas)
                    {
                        Console.WriteLine(subcadena);
                    }

                    


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
                    if()



                }





                    Console.ReadLine();
                Console.WriteLine("pulse s para continuar");
                    si = char.Parse(Console.ReadLine());
            } while(si == 's');
            
            










        }
    }
}
