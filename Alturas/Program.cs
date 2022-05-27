using System;

namespace Alturas
{

    class Programa
    {
        static void Main(string[] args)
        {

            int N, i, cont;
            double soma, media, porcentagem;
            string[] nome = new string[9];
            int[] idade = new int[9];
            double[] alturas = new double[9];

            Console.WriteLine("Quantas pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());


            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da ", i + 1, "a pessoa:");

                Console.WriteLine("Nome: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine());
            }


            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma += alturas[i];
            }


            media = soma / N;
            Console.WriteLine();
            Console.WriteLine("Altura media: " + media);


            cont = 0;
            for (i = 0; i < N; i++)
            {
                if (idade[i] < 16)
                {
                    cont = cont + 1;
                }
            }


            porcentagem = cont * 100 / N;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem + "%");


            for (i = 0; i < N; i++)
            {
                if (idade[i] < 16)
                {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}
