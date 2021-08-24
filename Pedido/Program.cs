using System;
using System.Globalization;
using SistemaPedido.Entidades;
using SistemaPedido.Entidades.Enumerador;

namespace SistemaPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data aniversário: ");
            DateTime dataAniversario = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Console.WriteLine("");
            Console.WriteLine("Informe o status do pedido:");
            Console.Write("Status: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, status, new Cliente(nome, email, dataAniversario));

            Console.WriteLine("");
            Console.Write("Informe a quantidade de itens do pedido:");
            int qtdeItensPedido = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeItensPedido; i++) {
                Console.WriteLine("");
                Console.WriteLine("Informe os dados do item #{0}", i);
                Console.Write("Produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                PedidoItem pedidoItem = new PedidoItem(new Produto(nomeProduto, preco), quantidade);

                pedido.AdicionarPedidoItem(pedidoItem);
            }

            Console.WriteLine("");
            Console.WriteLine(pedido);
        }
    }
}
