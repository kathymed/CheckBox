using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que acumule (sume) valores ingresados 
             * por teclado hasta ingresar el 9999 (no sumar dicho valor, 
             * indica que ha finalizado la carga). Imprimir el valor acumulado 
             * e informar si dicho valor es cero, mayor a cero o menor a cero.*/

            int suma = 0, valor;
            Console.WriteLine("Programa que suma valores");
            do
                {
                Console.WriteLine("Digite el valor:");
                valor = int.Parse(Console.ReadLine()); 
                if (valor == 9999)
                {
                    break;
                }
                else
                {
                    suma = suma + valor;
                }

           }
            while (valor != 9999);
            Console.WriteLine("El valor acumulado es:" +suma);            
             if (suma == 0)
            {
            Console.WriteLine("El valor acumulado es igual a cero");
            }
        else if (suma > 0)
        {
            Console.WriteLine("El valor acumulado es mayor a cero");
    }
        else
        {
             Console.WriteLine("El valor acumulado es menor a cero");
        }
            Console.ReadKey();
            }
        }
}