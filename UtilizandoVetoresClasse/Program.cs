using System;

namespace AdicionarVetoresClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos:");
            int qtdeProd = int.Parse(Console.ReadLine());

            Produto[] listaProdutos = new Produto[qtdeProd];

            for (int i = 0; i < qtdeProd; i++)
            { 
                Console.WriteLine("");
                Console.Write("Informe produto: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o preço: ");
                double preco = double.Parse(Console.ReadLine());

                listaProdutos[i] = new Produto(nome, preco);
            }

            double valorProdutos = 0;

            for (int i = 0; i < qtdeProd; i++)
            {
                valorProdutos += listaProdutos[i].Preco;
            }

            Console.WriteLine("");
            Console.WriteLine("Preço Medio: {0}", valorProdutos/qtdeProd);
        }
    }
}
