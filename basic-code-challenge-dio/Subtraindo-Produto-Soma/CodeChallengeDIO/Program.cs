using System;

namespace CodeChallengeDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int produto = 1, soma = 0;
            while (num > 0)
            {
                int l = num % 10;
                // TODO: Crie as outras condições necessárias para a resolução do desafio:
                produto *= l;
                soma += l;
                num /= 10;
            }
            Console.WriteLine(produto - soma);
        }
    }
}
