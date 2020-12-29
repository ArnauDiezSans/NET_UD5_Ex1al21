using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex9
    {
        public void Iniciar()
        {
            Console.WriteLine("Cuantas posiciones tiene el array:");
            int pos = Convert.ToInt32(Console.ReadLine());
            int[] ex9 = new int[pos];
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine("Introduce el valor de la posicion {0}", i);
                ex9[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine("{0}", ex9[i]);
            }
        }
    }
}
