using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex19
    {
        public bool EsPrimo(int n)
        {
            bool EsPrimo= true;
            double raiz = Math.Sqrt(n);
            for (int i = 2; i <= raiz; i++)
                if ((n % i) == 0) EsPrimo = false;
            return EsPrimo;
        }
        public void Iniciar()
        {
            Random R = new Random();
            int ra = 0;
            Console.WriteLine("Introduce cuantos numeros deseas generar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            int mayor = 0;
            Console.WriteLine("Introduce el valor minimo del rango de aleatorios:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el valor minimo del rango de aleatorios:");
            int max = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++){
            TryAgain:
                ra = Convert.ToInt32(R.Next(min - 1, max + 1));
                //ra = Convert.ToInt32(R);
                if (EsPrimo(ra)) { numeros[i] = ra; if (ra > mayor) { mayor = ra; } }
                else { goto TryAgain; }
            }
            Console.WriteLine("El mayor primo es {0}", mayor);
        }
    }
}
