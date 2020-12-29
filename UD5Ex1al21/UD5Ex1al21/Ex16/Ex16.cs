using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex16
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce cuantos numeros tiene el array:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Introduce el valor de la posición {0}", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            int nocapicua = 0;
            for (int i = 0; i < cantidad/2 && cantidad!=0; i++)
            {
                if (numeros[i] == numeros[cantidad - 1 - i])
                {
                    nocapicua = 1;
                }
            }
            if (nocapicua != 1) 
            {
                Console.WriteLine("No es capicua");
            }
            else
            {
                Console.WriteLine("Es capicua");
            }
        }
    }
}
