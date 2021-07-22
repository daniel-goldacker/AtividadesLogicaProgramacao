using System;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Produto: ");
            string produto = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Estoque: ");
            double estoque = int.Parse(Console.ReadLine());

            // Construtor com inicialização de classe
            Produto produtoClass = new Produto(produto, preco, estoque);
             
            // Sitaxe alternativa para inicar valores (Não precisa de construtor)
            Produto produtoClass3 = new Produto
            {
                Nome = "Rádio",
                Preco = 129.90,
                Estoque = 10
            };

            Console.WriteLine("");
            Console.WriteLine("Dados do Produto: {0}", produtoClass);
            Console.WriteLine("");

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidadeADD = int.Parse(Console.ReadLine());
            produtoClass.AdicionarProdutos(quantidadeADD);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: {0}", produtoClass);
            Console.WriteLine("");

            Console.WriteLine("Digite o número de produtos a ser removida do estoque: ");
            int quantidadeREM = int.Parse(Console.ReadLine());
            produtoClass.RemoverProdutos(quantidadeREM);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: {0}", produtoClass);
            Console.WriteLine("");
        }
    }
}
