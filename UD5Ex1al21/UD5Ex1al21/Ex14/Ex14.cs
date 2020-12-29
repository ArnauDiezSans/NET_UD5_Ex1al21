using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex14
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce cuantos numeros aleatorios del 1 al 10 quieres generar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el valor a buscar:");
            int valor = Convert.ToInt32(Console.ReadLine());
            int okei = 0;
            Random r = new Random();
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = r.Next(0, 11);
                Console.WriteLine("Posición {0}: Valor {1}", i + 1, numeros[i]);
                if (numeros[i] == valor)
                {
                    okei = 1;
                }
            }
            if (okei == 1)
            {
                Console.WriteLine("El valor esta en la matriz");
            }
            else
            {
                Console.WriteLine("El valor no esta en la matriz");
            }
        }
    }
}
