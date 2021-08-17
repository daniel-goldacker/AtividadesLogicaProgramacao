using System;
using UtilizandoENUM.Entidades;
using UtilizandoENUM.Enumerador;

namespace UtilizandoENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido() { NumPedido = "9999999", Momento = DateTime.Now, Status = StatusPedido.Processando};

            Console.WriteLine(pedido);

            // Converter um Enum em String 
            string status = StatusPedido.PagamentoPendente.ToString();

            Console.WriteLine(status);

            // Três formas de converter String em Enum
            StatusPedido os1 = Enum.Parse<StatusPedido>("Processando");
            StatusPedido os2 = (StatusPedido)Enum.Parse(typeof(StatusPedido), "ValorEnviado");
            StatusPedido os3;
            Enum.TryParse("ValorEntregue", out os3);

            Console.WriteLine(os1);
            Console.WriteLine(os2);
            Console.WriteLine(os3);
        }
    }
}
