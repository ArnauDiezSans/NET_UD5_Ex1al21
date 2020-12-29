using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex13
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce cuantos numeros aleatorios del 1 al 10 quieres generar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = r.Next(0, 11);
                Console.WriteLine("Posición {0}: Valor {1}", i + 1, numeros[i]);
            }
        }
    }
}
