using System;

namespace lista3
{
    public static class atividae7
    {
        public static void rodar()
        {
            Console.Write("Digite o valor de L: ");
            int L = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.WriteLine("Sequência de Fibonacci:");

            for (int i = 0; i < L; i++)
            {
                Console.Write("{0} ", a);
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}