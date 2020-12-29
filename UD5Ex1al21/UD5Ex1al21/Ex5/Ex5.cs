using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex5
    {
        public void Iniciar()
        {
            Console.WriteLine("Introduce un numero positivo:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                String cadena = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
                Console.WriteLine("El resultado binario es: {0}",cadena);
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
            Console.ReadLine();
        }
    }
}
