using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex7
    {
        public void Iniciar()
        {
            double LIBRA = 0.86;
            double DOLLAR = 1.28611;
            double YEN = 129.852;
            Console.WriteLine("Introduce el tipo desde el que deseas convertir:");
            Console.WriteLine("   1. Euros a Libras   4. Libras a Euros   7. Dolares a Libras   10. Yenes a Libras");
            Console.WriteLine("   2. Euros a Dolares  5. Libras a Dolares 8. Dolares a Euros    11. Yenes a Dolares");
            Console.WriteLine("   3. Euros a Yenes    6. Libras a Yenes   9. Dolares a Yenes    12. Yenes a Euros");
            Console.WriteLine("");
            Console.WriteLine("   (1 Euro = 0,86 Libras = 1,28611 Dolares = 129,852 Yenes");
            int tipo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad que quieres convertir:");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            switch (tipo)
            {
                case 1:  cantidad = cantidad * LIBRA; break;
                case 2: cantidad = cantidad * DOLLAR; break;
                case 3: cantidad = cantidad * YEN; break;
                case 4: cantidad = cantidad / LIBRA; break;
                case 5: cantidad = cantidad / LIBRA * DOLLAR; break;
                case 6: cantidad = cantidad / LIBRA * YEN; break;
                case 7: cantidad = cantidad / DOLLAR * LIBRA; break;
                case 8: cantidad = cantidad / DOLLAR; break;
                case 9: cantidad = cantidad / DOLLAR * YEN; break;
                case 10: cantidad = cantidad / YEN * LIBRA; break;
                case 11: cantidad = cantidad / YEN * DOLLAR; break;
                case 12: cantidad = cantidad / YEN; break;
            }
            Console.WriteLine("La cantidad convertida es:{0}", cantidad);

        }
    }
}
