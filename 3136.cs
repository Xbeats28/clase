using System;
using System.Diagnostics.Eventing.Reader;

namespace _31_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cont;

            do
            {
                int ejer;
                Console.WriteLine("a que ejercicio desea ir");
                ejer = int.Parse(Console.ReadLine());
                if (ejer == 31)
                {

                    int n;
                    Console.WriteLine("introduzca el valor del array");
                    n = int.Parse(Console.ReadLine());
                    double[] array = new double[n];
                    //a
                    Random random = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {


                        array[i] = random.Next(-20, -1);
                    }

                    for (int o = array.Length - 5; o < array.Length; o++)
                    {



                        array[o] = random.Next(1, 20);
                    }
                    for (int a2 = 0; a2 < 5; a2++)
                    {


                        array[a2] = random.Next(1, 20);
                    }
                    Console.WriteLine(array[1] + array[array.Length - 1]);
                    double[] copia = new double[n];
                    for (int i = 0; i < copia.Length; i++)
                    {
                        copia[i] = array[i];
                    }
                    for (int i = 0; i < copia.Length - 1; i++)
                    {
                        if (copia[i] > copia[i + 1])
                        {
                            double pos = copia[i + 1];
                            copia[i + 1] = copia[i];
                            copia[i] = pos;





                        }
                    }
                    for (int i = 0; i < copia.Length; i++)
                    {
                        Console.WriteLine(copia[i]);
                    }


                }
                if (ejer == 32)

                {

                 Console.WriteLine   ("Cuantos valores quieres que tenga la array");
                    int a1 = int.Parse(Console.ReadLine());
                    int[] a = new int[a1];
                    int suma = 0;
                    Random random = new Random();

                    for (int i = 0; i < a.Length; i++)
                    {

                        a[i] = random.Next(0, 10);
                     
                        suma = suma + a[i];
                    }
                    int media;
                    media = suma / a1;
                    Console.WriteLine("La media es" + media);



                    if (media <= 4)
                    {
                        Console.WriteLine("SUSPENSO");
                    }

                    if (media >= 5 && media < 7)
                    {
                        Console.WriteLine("Aprobado");
                    }

                    if (media > 7 && media < 9)
                    {
                        Console.WriteLine("Notable");
                    }

                    if (media >= 9 && media <= 10)
                    {
                        Console.WriteLine("sobresaliente");
                    }

                


                }
                                else if (ejer == 33) { 

                    Console.WriteLine("Digame el valor de la array n");
                    int n1 = int.Parse(Console.ReadLine());
                    double[] n = new double[n1];
                    double n2 = 0;
                    double suma = 0;
                    Random random = new Random();
                    double media = 0;
                   
                    
                        for (int i = 0; i < n.Length; i++)
                    {
                        n[i] = random.Next(0, 20);
                    
                        
                        

                    }
                    for (int i = 0; i < n.Length; i++)
                    {
                        media = n[i] + media;
                    }
                    media = media / n1;
                    for (int i = 0; i < n.Length; i++)
                    {

                        Console.WriteLine("La desviación es " + (n[i] - media));

                      



                    }
                }
                else if(ejer==34)
                {
                    int[] a = new int[5];   
                    int[] b = new int[5];
                    for(int i = 0; i < a.Length;i++)
                    {
                        Console.WriteLine("da un valor a la posicion del array");
                        a[i] = int.Parse(Console.ReadLine()); ;
                       
                       
                    }
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine("da un valor a la posicion del array");
                        
                        b[i] = a[i] + 10;

                    }
                    for (int i = 0; i <5; i++) { Console.WriteLine(b[i]); }

                }
                else if(ejer==35)
                {

                    Console.WriteLine("Dime cuantos valores quiere en su variable ");
                   int n = int.Parse(Console.ReadLine());
                  
                    double[] x = new double[n];
                    double suma = 0;
                    Random random = new Random();

                    for (int i = 0; i < x.Length; i++)
                    {

                        x[i] = random.Next(0, 20);
                        suma = suma + Math.Pow(x[i], 2);
                       
                    }
                    double raiz = 0;
                    raiz = Math.Sqrt(suma);
                    Console.WriteLine(raiz);
                }
                else if(ejer==36)
                {
                    int[] a = new int[5];
                    Random random = new Random();
                    for(int i = 0; i < a.Length;i++)
                    {
                        a[i] = random.Next(-100, 100);

                        Console.WriteLine(a[i]);
                    }
                    Console.WriteLine("el primer numero negativo en las posiciones es");
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] < 0)
                        {
                            Console.WriteLine(a[i]);
                            break;
                        }
                    }

                }
                else if(ejer==37)
                  {
                    Console.WriteLine("escriba un numero del 1 al 10");
                    int n = 0;
                    n = int.Parse(Console.ReadLine());
                    int[] a = new int[10];
                    Random random = new Random();   
                    for(int i = 0; i< a.Length;i++)
                    {
                        a[i] = random.Next(1, 10);
                    
                    }
                    int m = 0;
                    for( int i = 0; i < a.Length;)
                    {
                        if (a[i] == n)
                        {

                            Console.WriteLine(a[i]);
                            Console.WriteLine(i+ ""+ "es la posicion donde se encuentra");
                            m++;
                        }

                    }
                       if(m == 0) { Console.WriteLine("no existe ningun valor igual"); }
                }
                else if(ejer==38)
                {
                    
                }


                    Console.ReadLine();

                Console.WriteLine("pulse 's' para continuar");
                cont = char.Parse(Console.ReadLine());

            } while (cont == 's');
            


        }
    }
}
