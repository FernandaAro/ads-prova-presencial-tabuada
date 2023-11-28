using System;

namespace Prova
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada deseja executar?");
            int n = Convert.ToInt32(Console.ReadLine());
            Recursivo(n, 1);
        }

        static void Recursivo(int n, int i)
        {
            if (i > 10)
                return;

            Console.WriteLine(n + " x " + i + " = " + n * i);

            Recursivo(n, i + 1);
        }
    }
}
