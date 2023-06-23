using System;

namespace lista3
{
    public static class atividade2
    {
        public static void main()
        {
            Console.WriteLine("Digite uma sequência de valores inteiros separados por espaço: ");
            string[] valores = Console.ReadLine().Split(' ');
            //Para ler os valores de uma linha fiz a divisao desses valores usando " " a partir disso gero uma string
            
            int positivos = 0;
            int negativos = 0;
            int zeros = 0;

            foreach (string valor in valores)
            {
                int numero = int.Parse(valor);

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    zeros++;
                }
            }

            int total = valores.Length;
            double percentualPositivos = (double)positivos / total * 100;
            double percentualNegativos = (double)negativos / total * 100;
            double percentualZeros = (double)zeros / total * 100;

            Console.WriteLine($"Números positivos: {positivos} ({percentualPositivos}% do total)");
            Console.WriteLine($"Números negativos: {negativos} ({percentualNegativos}% do total)");
            Console.WriteLine($"Zeros: {zeros} ({percentualZeros}% do total)");
        }
    }
}