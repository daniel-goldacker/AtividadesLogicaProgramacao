using System;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();
            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Estoque: ");
            produto.Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Dados do Produto: {0}", produto);
            Console.WriteLine("");

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidadeADD = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidadeADD);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: {0}", produto);
            Console.WriteLine("");

            Console.WriteLine("Digite o número de produtos a ser removida do estoque: ");
            int quantidadeREM = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidadeREM);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: {0}", produto);
            Console.WriteLine("");
        }
    }
}
