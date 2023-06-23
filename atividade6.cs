using System;

namespace lista3
{
    public static class atividade6
    {
        public static void main()
        {
            Console.Write("Digite um número inteiro e positivo: ");
            int n = int.Parse(Console.ReadLine());

            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 1.0 / i;
                Console.Write("1/{0} + ", i);
            }

            Console.WriteLine("\n\nSoma final: {0}", s);
        }
    }
}