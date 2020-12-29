using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex17
    {
        public void Iniciar()
        {
            int cantidad = 10;
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Introduce el valor de la posición {0}", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Mostrar(numeros, cantidad);
        }
        public void Mostrar(int[] numeros, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("El valor de la posición {0} es {1}", i + 1, numeros[i]);
            }
        }
    }
}
