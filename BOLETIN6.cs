using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int ejer = 0;
            Console.WriteLine("a que ejercicio desea ir");
            ejer=int.Parse(Console.ReadLine());
            do {
                Console.WriteLine("inicio de apunte");
                //programa que trbje con 10 valores de tipo int
                int[] notas = new int[10];
                //modificar su valor en las posiciones 0, 3 y 7
                notas[0] = 9;
                notas[3] = 7;
                notas[7] = 5;
                //visualizar todas las posiciones por pantalla, hay que ponerlas uno a uno a caso de que se haga un bucle
                Console.WriteLine(notas[0] + " " + notas[3] + "" + notas[7]);
                for (int i = 0; i < 10; i++) { Console.WriteLine(notas[i]); }


                //hacer un programa que almacene 5 notas
                double[] notas2 = new double[5];
                int contador = 0;
                double media = 0;
                for (int i = 0; i < 5; i++)
                {


                    Console.WriteLine("escriba su nota");
                    notas2[i] = double.Parse(Console.ReadLine());

                    media = notas2[i] + media;

                }
                media = media / 5;
                Console.WriteLine(media);
                Console.WriteLine("Fin de apuntes");
                if (ejer == 1)
                {
                    int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    int[] a2 = new int[100];
                    for (int i = 0; i < 100; i++)
                    { a2[i] = i; }
                    //visualizar los dos arrays
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(a1[i] + "");
                    }
                    for (int i = 0; i < a2.Length; i++)
                    {


                       Console.WriteLine(a2[i]);
                    }

                }
                if (ejer == 2)
                {
                    float[] a3 = new float[20];
                    funciones.printArray(a3);
                }
                if(ejer==3)
                {
                    int[] a1 = new int[10];
                    a1[0] = -23;
                    a1[2] = -2;
                    a1[5]= -5;
                    a1[9]= -6;






                }
                if (ejer==4)
                {
                    string[] a2 = new string[5];
                    a2[1] = "el cid campeador";
                    a2[2] = " Asi es la puta vida";
                    a2[3] = "Las meditacios de Marco Aurelio";
                    a2[4] = " Habitos atomicos";
                    a2[0] = " 48 leyes del poder ( en proceso)";




                }
                if (ejer==5)
                {
                    short[] a5 = new short[4];
                    for (int i = 0; i< 4; i++)
                    {
                        Console.WriteLine("Introduza un valor");
                        a5[i]= short.Parse(Console.ReadLine());

                    }




                }
                if(ejer == 6)
                {
                    double[] a6 = new double[50];
                    a6[48] = -1;

                }
                if(ejer==7)
                {
                    Console.WriteLine("introduzca el valor de la capacidad que tendra el array");
                    int n = int.Parse(Console.ReadLine());
                    int[] a7 = new int[n];
                    a7[ a7.Length-1]= 9;
                    a7[a7.Length-a7.Length+1]= 10;



                }
                if(ejer==8)
                {
                    int[]a8 = new int[100];
                    for(int i = 0; i<a8.Length;i++)
                    {

                        a8[i] =                         
                    }


                }
                Console.ReadLine();
                                                    
                                        



                Console.WriteLine("pulse 's' para continuar");
                continuar = Convert.ToChar(Console.ReadLine());
            } while  (continuar=='s');
        } 
    }
}
