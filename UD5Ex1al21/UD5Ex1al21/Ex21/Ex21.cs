using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex21
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce cuantos numeros deseas generar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            Console.WriteLine("Elige el digito del 0 al 9:");
            int digito = Convert.ToInt32(Console.ReadLine());
            Random R = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = R.Next(1, 301);
            }
            List<int> numeros2 = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                if ((numeros[i]%10)==digito)
                {
                    numeros2.Add(numeros[i]);
                }
            }
            Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", numeros2));
        }
    }
}
