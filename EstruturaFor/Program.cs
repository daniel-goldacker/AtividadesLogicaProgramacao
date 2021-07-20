using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números inteiros que deseja somar :");
            int qtdNumeros = int.Parse(Console.ReadLine());

            double total = 0;
            
            for (int i = 1; i <= qtdNumeros; i++)
            {
                Console.WriteLine("Informe o número #{0}: ", i);
                total += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Total da soma é de {0}", total);
        }
    }
}
