using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex12
    {
        public void Iniciar()
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce el valor de la posición {0}", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < 10; i++)
            {
                array[0] = array[0] + array[i];
            }
            Console.WriteLine("La media es {0}", array[0]/10);
        }
    }
}
