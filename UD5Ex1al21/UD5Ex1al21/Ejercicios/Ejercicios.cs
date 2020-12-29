using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ejercicios
    {
        public int Selector()
        {
            int okei = 0;
            int a = 0;
            while (okei == 0)
            {
                Console.WriteLine("UD5 Métodos y Arrays");
                Console.WriteLine("   Ejercicio 1: Cálculo de áreas");
                Console.WriteLine("   Ejercicio 2: Generador de N aleatorios");
                Console.WriteLine("   Ejercicio 3: Averiguar si un número es primo");
                Console.WriteLine("   Ejercicio 4: Cálculo de factorial");
                Console.WriteLine("   Ejercicio 5: Conversor a binario");
                Console.WriteLine("   Ejercicio 6: Contador de cifras de un entero positivo");
                Console.WriteLine("   Ejercicio 7: Conversor de monedas");
                Console.WriteLine("   Ejercicio 8: Arrays 1");
                Console.WriteLine("   Ejercicio 9: Arrays 2");
                Console.WriteLine("   Ejercicio 10: Tablas de multiplicar");
                Console.WriteLine("   Ejercicio 11: Arrays 3. Suma de 10 números");
                Console.WriteLine("   Ejercicio 12: Arrays 4. Promedio de 10 números");
                Console.WriteLine("   Ejercicio 13: Arrays 5. N números aleatorios");
                Console.WriteLine("   Ejercicio 14: Arrays 6. Buscador en N números aleatorios");
                Console.WriteLine("   Ejercicio 15: Arrays 7. First in Last out");
                Console.WriteLine("   Ejercicio 16: Arrays 8. Capicua");
                Console.WriteLine("   Ejercicio 17: Arrays 9. Buscador de posición");
                Console.WriteLine("   Ejercicio 18: Arrays 10. Suma de N aleatorios del 1 al 9");
                Console.WriteLine("   Ejercicio 19: Arrays 11. Mayor de N primos");
                Console.WriteLine("   Ejercicio 20: Producto de dos arrays aleatorios");
                Console.WriteLine("   Ejercicio 21: Arrays 12. Buscar última cifra entre aleatorios 1-300");
                Console.WriteLine("");
                Console.WriteLine(" Introduce el número del ejercicio que deseas ejecutar");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if ((a <= 21) & (a > 0))
                {
                    okei = 1;
                }
            }
            return a;
        }

        public void Lanzador (int NUM)
        {
            
            switch (NUM)
            {
                case 1:
                    //Console.WriteLine("Ex1");
                    Ex1 E1 = new Ex1();
                    E1.Iniciar();
                    break;
                case 2:
                    Ex2 E2 = new Ex2();
                    E2.Iniciar();
                    break;
                case 3:
                    Ex3 E3 = new Ex3();
                    E3.Iniciar();
                    break;
                case 4:
                    Ex4 E4 = new Ex4();
                    E4.Iniciar();
                    break;
                case 5:
                    Ex5 E5 = new Ex5();
                    E5.Iniciar();
                    break;
                case 6:
                    Ex6 E6 = new Ex6();
                    E6.Iniciar();
                    break;
                case 7:
                    Ex7 E7 = new Ex7();
                    E7.Iniciar();
                    break;
                case 8:
                    Ex8 E8 = new Ex8();
                    E8.Iniciar();
                    break;
                case 9:
                    Ex9 E9 = new Ex9();
                    E9.Iniciar();
                    break;
                case 10:
                    Ex10 E10 = new Ex10();
                    E10.Iniciar();
                    break;
                case 11:
                    Ex11 E11 = new Ex11();
                    E11.Iniciar();
                    break;
                case 12:
                    Ex12 E12 = new Ex12();
                    E12.Iniciar();
                    break;
                case 13:
                    Ex13 E13 = new Ex13();
                    E13.Iniciar();
                    break;
                case 14:
                    Ex14 E14 = new Ex14();
                    E14.Iniciar();
                    break;
                case 15:
                    Ex15 E15 = new Ex15();
                    E15.Iniciar();
                    break;
                case 16:
                    Ex16 E16 = new Ex16();
                    E16.Iniciar();
                    break;
                case 17:
                    Ex17 E17 = new Ex17();
                    E17.Iniciar();
                    break;
                case 18:
                    Ex18 E18 = new Ex18();
                    E18.Iniciar();
                    break;
                case 19:
                    Ex19 E19 = new Ex19();
                    E19.Iniciar();
                    break;
                case 20:
                    Ex20 E20 = new Ex20();
                    E20.Iniciar();
                    break;
                case 21:
                    Ex21 E21 = new Ex21();
                    E21.Iniciar();
                    break;
            }
        }
    }
}
