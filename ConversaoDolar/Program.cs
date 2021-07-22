using System;

namespace ConversaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do U$ hoje: ");
            double cotacaoDolarHoje = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de U$ a ser comprado:" );
            double qtdDolarCompra = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em R$ é {0}.", ConversorDeMoeda.RetonaValorReais(cotacaoDolarHoje, qtdDolarCompra).ToString("F2"));

        }
    }
}
