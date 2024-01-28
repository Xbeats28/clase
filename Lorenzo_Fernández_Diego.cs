
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char si;
            double ejer;
            do

            
                
                {
                    Console.WriteLine("A que ejercicio desea ir");
                    ejer = Convert.ToDouble(Console.ReadLine());
                    while (ejer == 1)
                    {
                        Console.WriteLine("Ejercicio 1");
                    Console.WriteLine("a.");
                    int num = 500;
                    while (num >= 100)
                    { 
                        Console.WriteLine(num);
                        num = num - 100;
                    }
                    Console.WriteLine("b.");
                    int numb = 13;
                    while (numb <= 25)
                    {
                        Console.WriteLine(numb);
                        numb = numb + 2;
                       
                    }


                        break;
                    }
                    while (ejer == 2)
                {
                    double n, m, afirm;
                    afirm = 0;
                        Console.WriteLine("Escriba un numero");

                        n = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Escriba un numero mayor al anterior");
                        m = Convert.ToDouble(Console.ReadLine());
                    if ( n < m)
                    {
                        Console.WriteLine("primera fila 5 primeros numeros pares segunda fila multiplos de 11");
                        for (; n < m; n++)
                        {
                            if (n % 2 == 0 )
                            
                                afirm++;
                                if (afirm <= 5)
                                {
                                    Console.WriteLine(""+n+"");

                                }
                              

                               else if( n % 11 ==  0) {  Console.WriteLine(""+n+""); }
                            }


                        
                    }
                    else
                    {
                        double nb, mb, afirmb;
                        afirmb = 0;
                        Console.WriteLine("Vuelva a escribir un numero");

                        nb = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Escriba un numero mayor al anterior");
                        mb = Convert.ToDouble(Console.ReadLine());
                        if (nb < mb)
                        {
                            Console.WriteLine("primera fila 5 primeros numeros pares segunda fila multiplos de 11");
                            for (; nb < mb; nb++)
                            {
                                if (nb % 2 == 0)

                                    afirmb++;
                                if (afirmb <= 5)
                                {
                                    Console.WriteLine("" + nb + "");

                                }


                                else if (nb % 11 == 0) { Console.WriteLine("" + nb + ""); }
                            }
                            



                        }else { Console.WriteLine("no me vaciles"); }
                    }
                    

                    break;
                } while (ejer == 3) {
                    Console.WriteLine("Ejercicio 3");
                    Console.WriteLine("Escriba un numero");
                    double i = 0;
                    i = Convert.ToDouble(Console.ReadLine());
                    if (10 < i) 
                    { 
                    for (; i>=10; i--)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(1+(Math.Pow(i,3) + 1)/2);

                            }

                        }

                    }

                    if (10 > i)
                    {
                        for (; i <= 10; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(1 + (Math.Pow(i, 3) + 1) / 2);

                            }

                        }

                    }


                    break;
                }while (ejer == 4)
                {
                    Console.WriteLine("Ejercicio 4");
                    {
                        double n = 0, num = 0;
                        int damn = 0;
                        Console.WriteLine("Escriba un numero");
                        n = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Escriba un numero");
                        num = Convert.ToDouble(Console.ReadLine());
                        if (num < n)
                        {
                            for (int i = 2; i <= n; i++)
                            {
                                if (num % i == 0 && n % i == 0)
                                {
                                    damn++;
                                    if (damn == 0) 
                                    { Console.WriteLine("son primos entre si"); }
                                   
                                }
                                else if(damn==1) 
                                { Console.WriteLine("no son primos"); }
                            }
                        }
                        else if (num > n)
                        {
                            for (int i = 2; i <= num; i++)
                            {
                                if (num % i == 0 && n % i == 0)
                                {
                                    damn++;
                                    if (damn == 0) 
                                    { Console.WriteLine(" son primos entre si"); }
                                    
                                }
                                else  if(damn==1) 
                                { Console.WriteLine(" no son primos entre si"); }
                            }
                        }
                    }
                    break;  }





                    Console.WriteLine("Pulse 's' para continuar");
                    si = Convert.ToChar(Console.ReadLine());
                } while (si == 's');


            
            
            }
    }
}
