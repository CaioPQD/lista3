﻿using System;

namespace lista3
{
    public static class atividade4
    {
        public static void rodar()
        {
            Console.Write("Digite um valor inteiro e positivo: ");
            int n = int.Parse(Console.ReadLine());

            double e = 1.0;
            int fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
                e += 1.0 / fatorial;
            }

            Console.WriteLine($"O valor de E é {e}");
        }
    }
}