using System;

namespace EntradaDadosSimplesSPLIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu ultimo nome, idade e altura (Mesma linha)?");
            string[] dados = Console.ReadLine().Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto);

            foreach (var item in dados)
            {
                Console.WriteLine(item);
            }
        }
    }
}
