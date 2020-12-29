using System;

namespace UD5Ex1al21
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios Exe = new Ejercicios();
            int Num = Exe.Selector();
            Exe.Lanzador(Num);
        }
    }
}
