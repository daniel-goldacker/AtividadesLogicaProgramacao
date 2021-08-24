using System;
namespace SistemaPedido.Entidades
{
    public class PedidoItem
    {

        public Produto Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public PedidoItem()
        {
        }

        public PedidoItem(Produto produto, int quantidade)
        {
            Produto = produto;
            Preco = Produto.Preco;
            Quantidade = quantidade;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }
    }
}
