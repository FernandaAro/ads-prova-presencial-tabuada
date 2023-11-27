using System;

namespace Prova
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada deseja executar?");
            int tabuada = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine(tabuada + " x " + n + " = " + n * tabuada);
            }
        }
    }
}
