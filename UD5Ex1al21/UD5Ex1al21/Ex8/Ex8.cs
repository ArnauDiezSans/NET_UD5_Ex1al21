using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex8
    {
        public void Iniciar()
        {
            Console.WriteLine("Cuantas posiciones tiene el array:");
            int pos = Convert.ToInt32(Console.ReadLine());
            int[] ex8 = new int[pos];
            for (int i = 0; i < pos; i++)
            {
                ex8[i] = i;
                Console.WriteLine("{0}", ex8[i]);
            }

        }
    }
}
