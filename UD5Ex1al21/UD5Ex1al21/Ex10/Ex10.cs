using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex10
    {
        public void Iniciar()
        {
            Console.WriteLine("Elige una tabla de multiplicar del 1 al 10:");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0}x{1}={2}", x, i, x * i);
            }
        }
    }
}
