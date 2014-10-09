using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un vector de n elementos de tipo entero 
             * (n se ingresa por teclado) Mostrar cuantos elementos 
             * son superiores a 100 (emplear el foreach para recorrer el vector).*/
            int[] vector;
            Console.WriteLine("Programa vector 100");
            Console.WriteLine("Digitar el tamaño del vector:");
            int tamanio, contador, contador3=0;
            tamanio = int.Parse(Console.ReadLine());
            vector = new int[tamanio];
            for (contador = 0; contador <= tamanio-1; contador++)
            {
                Console.WriteLine("Digite numero");
                vector[contador] = int.Parse(Console.ReadLine()); 
        }
            Console.WriteLine("El vector es:");
            foreach (int contador2 in vector)
        {
                Console.WriteLine(contador2);
                if(contador2 > 100) 

        {
            contador3 = contador3 + 1;
        }

    }
            Console.WriteLine("Los numeros numeros mayores de 100 son:"+contador3);
            Console.ReadKey();
}
}
}
