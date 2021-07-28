using System;

namespace UtilizandoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de campos: ");
            int qtde = int.Parse(Console.ReadLine());

            double[] vet = new double[qtde];

            Console.WriteLine("");
            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine("Informe o valor {0}: ", i + 1);
                vet[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0;

            for (int i = 0; i < qtde; i++)
            {
                soma += vet[i];
            }

            Console.WriteLine("Média: {0}", soma/qtde);
        }
    }
}
