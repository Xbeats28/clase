using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace raices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calcular una raiz de un numero
            int numer = 20;
            double numero1 = Math.Sqrt(numer);
            float numero2 =(float)Math.Sqrt(numer);
            //calcular raiz enesima --> math.pow(base,1/n)
            //calcular potencias
            int x = 9;
            int y = 4;

            long potencia =  (long)Math.Pow(x, y);
            //redondeo
            float valor =4.6f;

            float valorintermenor = (float)Math.Floor(valor);
            Console.WriteLine(valor + " redondeado " + valorintermenor);

            float valorintermayor = (float)Math.Ceiling(valor);

            float intercercano = (float)Math.Round(valor);

            Console.WriteLine(valor + "redonde" +intercercano);
            //ajuste de numeros decimales
            float valor2 = 4.67890f;
            float valoredondeado = (float)Math.Round(valor2, 3);
            //esta no modifica el valor de valor2 si queremos mostrar el resultado tendriamos que poner un console.writeline
            Console.WriteLine((float)Math.Round(valor2, 1));
            //asi si se cambiaria el valor
            valor2 = (float)Math.Round(valor2, 2);

        }
    }
}
