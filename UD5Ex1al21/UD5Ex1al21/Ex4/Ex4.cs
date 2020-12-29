using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex4
    {
        public void Iniciar()
        {
            int num;
            do
            {
                Console.Write("Introduce un número entero positivo: ");
                num = Convert.ToInt32(Console.ReadLine());
                verificar(num);
            } while (num < 0);
            factorial(num);
            Console.ReadKey();
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Error: No existe el factorial de un número negativo...");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact*i;
            }
            Console.WriteLine("El Factorial de {0} es: {1}", n, fact);
        }
    }
}
