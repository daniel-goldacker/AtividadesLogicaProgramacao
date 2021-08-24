using System;
using System.Collections.Generic;
using System.Text;
using SistemaPedido.Entidades.Enumerador;

namespace SistemaPedido.Entidades
{
    class Pedido
    {

        public DateTime Data { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> PedidoItem { get; set; } = new List<PedidoItem>();

        public Pedido()
        {
        }

        public Pedido(DateTime data, StatusPedido statusPedido, Cliente cliente)
        {
            Data = data;
            StatusPedido = statusPedido;
            Cliente = cliente;
        }

        public void AdicionarPedidoItem(PedidoItem pedidoItem)
        {
            PedidoItem.Add(pedidoItem);
        }

        public void RemoverPedidoItem(PedidoItem pedidoItem)
        {
            PedidoItem.Remove(pedidoItem);
        }

        public double Total()
        {
            double total = 0;

            foreach (var item in PedidoItem)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUMÁRIO DO PEDIDO");
            sb.Append("Data do pedido: ");
            sb.AppendLine(Data.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Status pedido: ");
            sb.AppendLine(StatusPedido.ToString());
            sb.Append("Cliente: ");
            sb.Append(Cliente.Nome);
            sb.Append(" (");
            sb.Append(Cliente.DataAniversario.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("ITENS DO PEDIDO: ");

            foreach (var item in PedidoItem)
            {
                sb.Append(item.Produto.Nome);
                sb.Append(", R$ ");
                sb.Append(item.Preco);
                sb.Append(", Quantidade: ");
                sb.Append(item.Quantidade);
                sb.Append(", Subtotal: R$ ");
                sb.AppendLine(item.SubTotal().ToString());
            }

            sb.Append("Preço Total: ");
            sb.AppendLine(Total().ToString());

            return sb.ToString();
        }
    }
}
