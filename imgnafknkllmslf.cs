using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
                    double o = 0;
                    double suma = 0;
                    for (; o < num;o++)
                    {
                        if (num % o == 0)
                        {
                           
                            suma = suma + o;
                            
                        }

                    }
                    if (suma == num)
                    {
                        Console.WriteLine("Numero perfecto");
                    }
                    else Console.WriteLine("No es perfecto");

                }
                if (ejer == 14)
                {
                    Console.WriteLine("Escriba un numero");
                    double numm;
                    numm = Convert.ToDouble(Console.ReadLine());
                    double sumaalmacenada = 0;
                    for (double suma = 0; suma <= numm*5; suma++)
                    {
                        if (suma % 5 ==0)
                        {
                            
                            sumaalmacenada = suma + sumaalmacenada;
                            
                               
                        }
                       

                    }
                    Console.WriteLine(sumaalmacenada);


                }
                else if (ejer==15)
                {
                    Console.WriteLine("Escriba un numero");
                    double numn = 0;
                        numn = Convert.ToDouble(Console.ReadLine());
                    double multiplicacion = 1;
                    for (; numn > 1; numn --)
                    {
                        multiplicacion = multiplicacion * numn;

                    }
                    Console.WriteLine(multiplicacion);




                }
                else if (ejer == 16)
                {
                    Console.WriteLine("Escriba un numero");
                    double num;
                    double suma = 0;
                    num = 0;
                    num = Convert.ToDouble(Console.ReadLine());
                    double ikenna = 0;
                    for (; num > 1; num --)
                    {
if (num % 3 == 0) {
                            ikenna++;
                           


                        }

                    }
                    Console.WriteLine(ikenna);


                }
                else if (ejer == 17)
                {
                    Console.WriteLine("Introduzca un numero");
                    double num = 0;
                    double contador= 0;
                    num= Convert.ToDouble(Console.ReadLine());
                    double suma = 0;
                    for (; suma <= num; suma++) {
                    if (num % suma == 0)
                        {
                            contador++;
                        }
                        
                    
                    }
                    Console.WriteLine(contador);




                }
                else if ( ejer == 18)
                {
                    double num = 0;
                   
                        Console.WriteLine("Introduzca un numero");
                    
                    num = Convert.ToDouble(Console.ReadLine());
                  double  num2 = num;
                    
                    
                        for ( double resta= 0; num >resta;num2--)
                        {
                            if (num % num2 ==0){
                                Console.WriteLine("No es primo");

                            break;
                            }

                    } 
                    {
                        Console.WriteLine("Si es primo");
                    }



                  


                }



                Console.WriteLine("Desea continuar? pulse s para seguir o n para parar");
                si = Convert.ToChar(Console.ReadLine());        
            } while (si == 's');
        }
    }
}
