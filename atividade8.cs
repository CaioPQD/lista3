using System;

namespace lista3
{
    public static class atividade8
    {
        public static void main()
        {
            Console.Write("Digite o valor de L: ");
            int L = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            while (a < L)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}