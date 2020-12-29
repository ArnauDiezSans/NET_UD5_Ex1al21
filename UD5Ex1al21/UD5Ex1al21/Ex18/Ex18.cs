using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex18
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce cuantos numeros aleatorios del 1 al 9 quieres generar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            
            int[] numeros = new int[cantidad];
            Rellenar(numeros, cantidad);

        }
        public void Rellenar(int[] numeros, int cantidad)
        {
            Random r = new Random();
            int total = 0;
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = r.Next(1, 11);
                total = total + numeros[i];
                Console.WriteLine("El valor de la posición {0} es {1}", i + 1, numeros[i]);
            }
            Console.WriteLine("La suma total es:{0}", total);
        }

    }
}
