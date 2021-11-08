using System;
using System.Globalization;
using AutomatizacaoContrato.Entidades;
using AutomatizacaoContrato.Servico;

namespace AutomatizacaoContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informações do contrato:");
            Console.Write("Número: ");
            int nContrato = Int32.Parse(Console.ReadLine());

            Console.Write("Data: ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Parcelas: ");
            int parcela = Int32.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(nContrato, data, valor);

            ServicoProcessarParcela gerarParcela = new ServicoProcessarParcela(new ServicoPaypal());

            gerarParcela.ProcessarParcelas(contrato, parcela);
            
            Console.WriteLine("");
            Console.WriteLine("FATURAS: ");
            Console.WriteLine(contrato.ToString());
        }
    }
}
