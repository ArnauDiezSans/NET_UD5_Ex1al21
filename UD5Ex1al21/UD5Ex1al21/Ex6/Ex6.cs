using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex6
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce un entero decimal:");
            int num = Convert.ToInt32(Console.ReadLine());
            int decimales = Convert.ToInt32(Math.Floor(Math.Log10(num) + 1));
            Console.WriteLine("El numero {0} tiene {1} digitos.", num, decimales);
        }
    }
}
