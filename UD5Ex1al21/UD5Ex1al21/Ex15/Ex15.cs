using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex15
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce cuantos numeros tiene el array:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            int[] numeros2 = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Introduce el valor de la posición {0}", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                numeros2[cantidad - 1 - i] = numeros[i];
            }
            Console.WriteLine("");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Posicion {0}: Valor {1}", i+1, numeros2[i]);
            }
            {

            }
        }
    }
}
