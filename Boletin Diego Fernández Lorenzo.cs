using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace boletin4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do
            {
                Console.WriteLine("a que ejercicio quieres ir");
                int a;
                a = int.Parse(Console.ReadLine());
                if (a == 9)
                {
                    Console.WriteLine("escriba un numero");
                    double b = double.Parse(Console.ReadLine());
                    if (b % 2 == 0 && b % 3 == 0)
                    { Console.WriteLine("es multiplo entre 2 y 3"); }
                    else if (b % 2 == 0) { Console.WriteLine("es multiplo entre 2"); }
                    else if (b % 3 == 0) { Console.WriteLine("es multiplo entre 3"); }



                }
                else if (a == 10)
                {
                    Console.WriteLine("cual es el precio del producto");
                    double precio;
                    precio = double.Parse(Console.ReadLine());
                    if (precio > 100)
                    {
                        Console.WriteLine(precio - (precio * 0.15));
                    }
                    else { Console.WriteLine(precio - (precio * 0.1)); }


                }
                else if (a == 11)
                {
                    Console.WriteLine("escriba su nota");
                    double nota;
                    nota = Convert.ToDouble(Console.ReadLine());
                    if (nota > 10 || nota < 0) { Console.WriteLine("error en nota"); }
                    else if (nota < 5) { Console.WriteLine("suspenso"); }

                    else if (nota >= 5 && nota <= 6.5) { Console.WriteLine("aprobado"); }

                    else if (nota > 6.5 && nota <= 8.5) { Console.WriteLine("notable"); }

                    else if (nota >= 8.6 && nota <= 10) { Console.WriteLine("sobresaliente"); }

                    else if (a == 12)
                    {
                        Console.WriteLine("escriba un numero");
                        double ni;
                        ni = Convert.ToDouble(Console.ReadLine());
                        if (ni % 4 == 0)
                        { Console.WriteLine(ni + 25); }
                        else if (ni % 5 == 0) { Console.WriteLine(ni + 50); }
                        else { Console.WriteLine(ni + 100); }

                    }
                }
                else if (a == 13)
                {
                    double temp;
                    Console.WriteLine("cual es la temperatura");
                    temp = Convert.ToDouble(Console.ReadLine());
                    if (temp < 0) { Console.WriteLine("solido"); }
                    else if (temp < 100 && temp >= 0) { Console.WriteLine("liquido"); }
                    else if (temp > 100 && temp < 1000000) { Console.WriteLine("vapor"); }
                    else if (temp >= 1000000) { Console.WriteLine("plasma"); }





                }

                else if (a == 14)
                {

                    Console.WriteLine("Que quieres hacer a) sumar b) restar c) multiplicacion d) division");
                    char operacion;
                    operacion = char.Parse(Console.ReadLine());
                    switch (operacion)
                    {
                        case 'a':
                            Console.WriteLine("introduzca un numero");
                            double c, b;
                            c = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("introduzca otro numero");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(c + b);

                            break;
                        case 'b':
                            Console.WriteLine("introduzca un numero");
                            double l, o;
                            l = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("introduzca otro numero");
                            o = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(l - o);
                            break;
                        case 'c':
                            Console.WriteLine("introduzca un numero");
                            double i, v;
                            i = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("introduzca otro numero");
                            v = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(i * v);

                            break;
                        case 'd':
                            Console.WriteLine("introduzca un numero");
                            double t, k;
                            t = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("introduzca otro numero");
                            k = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(t / k);
                            break;
                        default:
                            Console.WriteLine("te equivocaste de letra");
                            break;
                    }


                }
                else if (a == 15)
                {
                    char operation;
                    Console.WriteLine("introduzca cuantos litros ha consumido a) menos de 50L b) mas de 50 menos de 200 c) mas de 200");
                    operation = char.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case 'a':
                            Console.WriteLine("No tienes que pagar nada");
                            break;
                        case 'b':
                            Console.WriteLine("introduzca cuantos litros ha utilizado");
                            double lu, lm;
                            lu = Convert.ToDouble(Console.ReadLine());
                            lm = lu - 50;
                            Console.WriteLine(lm * 4.75);

                            break;
                        case 'c':
                            Console.WriteLine("cuantos litros has consumido");
                            double lum, lun, ni, ra;
                            lum = Convert.ToDouble(Console.ReadLine());
                            lun = lum - 50;
                            ni = lun * 4.75;
                            ra = (lum - 200) * 20;
                            Console.WriteLine(ni + ra);
                            break;
                    }


                }
                else if (a == 16)
                {
                    Console.WriteLine("cual es el precio de uno de los articulos");
                    double precio, pr1, pr2, pr3;
                    pr1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("cual es el precio de otro articulo");
                    pr2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cual es el precio de otro articulo");
                    pr3 = Convert.ToDouble(Console.ReadLine());

                    precio = pr1 + pr2 + pr3;
                    if (precio <= 500) { Console.WriteLine("Gracias por su compra" + precio); }
                    else if (precio > 500 && precio <= 1000)
                    {
                        precio = (precio * 0.03) - precio;
                        Console.WriteLine("Gracias por su compra, se le ha aplicado un desceunto de un 3%" + precio);
                    }
                    else if (precio > 1000 && precio < 2000)
                    {
                        precio = (precio * 0.05) - precio;
                        Console.WriteLine("Gracias por su compra, se le ha aplicado un desceunto de un 3%" + precio);

                    }
                    else if (precio > 2000 && precio <= 3000)
                    {
                        precio = (precio * 0.07) - precio;
                        Console.WriteLine("Gracias por su compra, se le ha aplicado un desceunto de un 3%" + precio);
                    }
                    else if (precio > 3000)
                    {
                        precio = (precio * 0.1) - precio;
                        Console.WriteLine("Gracias por su compra, se le ha aplicado un desceunto de un 3%" + precio);
                    }




                }
                else if (a == 17)
                {
                    double b;
                    Console.WriteLine("Cuantas horas trabaja");
                    b = Convert.ToDouble(Console.ReadLine());
                    if (b <= 38)
                    {
                        Console.WriteLine("A cuanto se le paga la hora");
                        double horas, burto, neto;
                        horas = Convert.ToDouble(Console.ReadLine());
                        burto = b * horas;
                        if (burto <= 300) { Console.WriteLine("te libras de pagar impuestos" + burto); }
                        else
                        {
                            burto = burto - (burto * 0.1);
                            Console.WriteLine("manin paga impuestos del 10% de tu sueldo" + burto);

                        }
                    }
                    else if (b > 38)
                    {
                        Console.WriteLine("A cuanto se le paga la hora");
                        double htr, pdw, ost;
                        htr = double.Parse(Console.ReadLine());
                        htr = htr * b;
                        Console.WriteLine("cuantas horas a trabjado a mas de 38 HORAS");
                        pdw = double.Parse(Console.ReadLine());
                        double no;
                        no = htr + pdw;
                        ost = ((htr * 0.5) + htr) * pdw;
                        if (no <= 300) { Console.WriteLine("te libras de pagar impuestos" + pdw); }
                        else
                        {
                            no = no - (no * 0.1);
                            Console.WriteLine("manin paga impuestos del 10% de tu sueldo" + no);

                        }



                    }
                    else if (a == 18) ;
                    Console.WriteLine("ESCRIBA 1 ,2 3 O 4");
                    double INDICADOR;
                    INDICADOR = double.Parse(Console.ReadLine());
                    switch (INDICADOR)
                    {
                        case '1':
                            Console.WriteLine("calor");
                            break;
                        case '2':
                            Console.WriteLine("templeado");
                            break;
                        case '3':

                            Console.WriteLine("Frio");
                            break;
                        case '4':
                            Console.WriteLine("fuera de rango");
                            break;
                        default:
                            Console.WriteLine("un valor dentro de los que te he dado");
                            break;

                    }








                }
                else if (a == 20)
                {

                    Console.WriteLine("Escriba un numero de hasta 6 cifras");
                    double nig;
                    nig = double.Parse(Console.ReadLine());
                    if (nig < 10)
                    { Console.WriteLine("el numero tiene 1"); }
                    else if (nig < 100)
                    { Console.WriteLine("el numero tiene 2"); }
                    else if (nig < 1000)
                    { Console.WriteLine("el numero tiene 3"); }
                    else if (nig < 10000)
                    { Console.WriteLine("el numero tiene 4"); }
                    else if (nig < 100000)
                    { Console.WriteLine("el numero tiene 5"); }
                    else if (nig < 1000000)
                    { Console.WriteLine("el numero tiene 6"); }
                    else { Console.WriteLine("Te dije de 6 cifras >;l"); }

                }
                else if (a == 19)
                {
                    Console.WriteLine("R,r) Rojo V,v)Verde A,a)Azul si pones otros afrontaras tus oscuras consecuencias");
                    char color;

                    color = char.Parse(Console.ReadLine());
                    switch (color)
                    {
                        case 'R':
                            Console.WriteLine("Rojo");


                            break;
                        case 'r':
                            Console.WriteLine("Rojo");


                            break;
                        case 'V':
                            Console.WriteLine("Verde");


                            break;
                        case 'v':
                            Console.WriteLine("Verde");


                            break;
                        case 'A':
                            Console.WriteLine("Azul");



                            break;
                        case 'a':
                            Console.WriteLine("Azul");


                            break;
                        default:
                            Console.WriteLine("Negro");
                            break;
                    }











                }
                else if (a == 21)
                {
                    Double aa, b, c, x1, x2;
                    Console.WriteLine("introduzca un valor");
                    aa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("introduza otro valor");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("introduzca otro valor");
                    c = Convert.ToDouble(Console.ReadLine());
                    if (aa == 0)

                    {
                        x1 = 0;
                        x2 = c / b;
                        Console.WriteLine("las incongnitas son:" + x1 + "x2:" + x2);

                    }
                    else if (b == 0)
                    {

                        x2 = 0;
                        x1 = Math.Sqrt((c / aa));
                        if (x1 <= 0)
                        { Console.WriteLine("La raiz es negativa no se puede realizar"); }
                        else
                        {

                            Console.WriteLine("X1:" + x1 + "X2:" + x2);
                        }


                    }
                    else if (c <= 0)
                    {
                        x1 = 0;
                        x2 = b / aa;
                        Console.WriteLine("X1:" + x1 + "x2;" + x2);

                    }
                    else
                    {



                        if (Math.Sqrt((b * b - 4 * a * c)) < 0)
                        {
                            Console.WriteLine("El resultado de la raiz es negativo");

                        }
                        else
                        {
                            Math.Sqrt((b * b - 4 * a * c));
                            double ni;
                            ni = Convert.ToDouble(Console.ReadLine());

                            x1 = -b + ni / 2;
                            x2 = -b - ni / 2;
                            Console.WriteLine("x1:" + x1 + "x2:" + x2);
                        }

                    }






                }
                else if (a == 22)
                {
                    Console.WriteLine("Introduzca la fecha de un año");
                    double año;
                    año = Convert.ToDouble(Console.ReadLine());
                    if (año % 100 == 0)
                    {
                        if (año % 400 == 0) { Console.WriteLine("Es bisiesto"); }
                        else { Console.WriteLine("el año no es bisiesto"); }
                    }
                    else if (año % 6 == 0) { Console.WriteLine("El año es bisiesto"); }
                    else { Console.WriteLine("El año no es bisiesto"); }

                }

                else if (a == 23)
                {
                    Console.WriteLine("escriba 1 numero");
                    double so, ni, cr;
                    so = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("escriba 1 numero");
                    ni = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escriba 1 numero");
                    cr = Convert.ToDouble(Console.ReadLine());
                    if (so > cr && so > ni && ni > cr) { Console.WriteLine(so + "" + ni + "" + cr); }

                    else if (so < cr && so < ni && ni > cr) { Console.WriteLine(ni +""+ cr +""+ so); }
                    else if (so > cr && so < ni && ni > so) { Console.WriteLine(ni + "" + so + "" + cr); }
                    else if (so > cr && so > ni && cr > ni) { Console.WriteLine(so + "" + cr + "" + ni); }
                    else if (cr > so && cr > ni && ni > so) { Console.WriteLine(cr + "" + ni + "" + so); }
                    else if (cr > so && cr > ni && so > ni) { Console.WriteLine(cr + "" + so + "" + ni); }
                    else Console.WriteLine("Por favor numeros diferentes");
                }


























                        Console.WriteLine("desea continuar? Pulse S para continuar o N para cerrar");
                continuar = char.Parse(Console.ReadLine());


            }
            while (continuar == 's');












































































































































































































                Console.ReadLine();




            }
        }
    }

