using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_aritmeticos_matematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operadores maematcos
            // % el resto de la division entera
            int a = 9;
            int resto = a % 2;
            // operadores + con variables tipo byte o short
            //lo que pasa aqui es que el + lo pasa a tipo int por lo que hay que pasarlo
            byte n1 = 9;

            byte n2 = 10;

            short suma = (short)(n1 + n2);

            //operaodres de asignacion +=
            int x = 1;
            x += 1; //x=x + 1;

            x += 9;
            //sirve para cambiar el valor de x += sumandole

            //peradores relacionales
            int s1 = 9;
            int s2 = 6;
            bool condicion1 = s1 == s2;
            bool condicion2 = s1 == 9;

            // operadores logicos
            // logico --> && --> A&&B --> devuelve si true si A y B on true
            // ! es si es distinto
            // == es si es igual
            bool condicion3 = (9 > 5) && (9 != 0);
            bool condcion4 = (9 == 0) && (9 > 5);
            // O logico --> --> A || B__> Devuelve true si A  0 B son true
            bool condicion5 = (9 > 5) || (9 % 2 ==0);
            bool condicion6 = (9 < 5) || (9 % 2 == 0);
            bool condicion7 = (9 < 5) || (9 % 2 != 0);
            //no logico ! niega lo que  va despues
            // true = false false = true




        }
    }
}
