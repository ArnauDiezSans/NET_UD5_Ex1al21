using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex3
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce un numero para comprobar si es primo o no:");
            int num = Convert.ToInt32(Console.ReadLine());
            int primo = Calculo(num);
            if (primo == 0)
            {
                Console.WriteLine("El numero {0} es primo", num);
            }
            else
            {
                Console.WriteLine("El numero {0} no es primo", num);
            }
        }

        int Calculo (int num)
        {
            int EsPrimo=0;
            for (int i=2; i<num; i++)
            {
                if (num%i==0)
                    {
                        EsPrimo = 1;
                    }
            }
            return EsPrimo;
        }
    }
}
