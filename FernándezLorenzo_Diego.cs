using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Diego_F_Lorenzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 2 examen
            Console.WriteLine("introduzca un numero");
            // apartado a
            int valorsoli;
            valorsoli = int.Parse(Console.ReadLine());
            //apartado a 
            double raiz;
            raiz = Math.Sqrt(valorsoli);
            //aqui lo redondeo a 2 decimales
            raiz = Math.Round(raiz, 2);
            Console.WriteLine("Raiz=" + raiz);
            // apartado b
            double numeroelevado;
            numeroelevado = Math .Pow(valorsoli, 6);
            Console.WriteLine("Numero elevado a 6="+  numeroelevado);
            //apartado a c
            short variabltshort;
            variabltshort = (short)numeroelevado;
            Console.WriteLine("Variable almacenada en tipo short=" + variabltshort);
            //apartado d
            float porcentaje, multi , resta;
            multi = valorsoli * 20;
            porcentaje = multi / 100;
            resta = valorsoli - porcentaje;
            Console.WriteLine("el porcentaje es =" + resta);
            //apartaado e
            double porcentaje35 , division, calculado;
            porcentaje35 = valorsoli * 35;
            division = porcentaje35 / 100;
            calculado = valorsoli + division;
            valorsoli = (int)calculado;
            Console.WriteLine("valor alterado de valorsoli (sigue siendo tipo int) por un 35%=" + valorsoli);
            //al seguir siendo tipo int se queda con el valor redondeado en el caso de 4 se quedara con5
            Console.WriteLine();
           //ejercicio 3
            //aqui pido y declaro las variables principales
            Console.WriteLine("ejercciio 3");
            Console.WriteLine("cuanto le pagan la hora");
            float horast, horasts, irpf;
            horast = float.Parse(Console.ReadLine());
            Console.WriteLine("cuantas horas trabaja a la semana");
            horasts = float.Parse(Console.ReadLine());
            Console.WriteLine("introuzca su irpf ( sin el simbolo %)");
            irpf = float.Parse(Console.ReadLine());
            float horastotales;
           // apartado a calculo las horas totales al mes
            horastotales = horasts * 4;
            Console.WriteLine("al mes trabaja un total de" + horastotales);
            //apartado b aqui calculo el salariobruto
            float salariobruto;
            salariobruto = horastotales * horast;
            Console.WriteLine("Su salario bruto es de=" + salariobruto);
            float salarioneto, damn;
            damn = salariobruto * irpf / 100;
           //apartado c aqui calculo el salario neto
            salarioneto = salariobruto - damn;
            Console.WriteLine("Su salario neto es de=" + salarioneto);
            
            Console.ReadLine(); 



            
            

        }
    }
}
