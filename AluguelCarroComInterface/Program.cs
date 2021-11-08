using System;
using System.Globalization;
using AluguelCarroSemInterface.Servico;

namespace AluguelCarroSemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Informe os dados do aluguel");
            Console.Write("Modelo do carro: ");
            string modeloCarro = Console.ReadLine();

            Console.Write("Data inicio (DD/MM/YYYY HH:MM): ");
            DateTime dataRetirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Data fim (DD/MM/YYYY HH:MM): ");
            DateTime dataDevolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AlugelCarro alugelCarro = new AlugelCarro(dataRetirada, dataDevolucao, new Veiculo(modeloCarro));

            ServicoAluguel servicoAluguel = new ServicoAluguel(precoHora, precoDia, new TaxaServicoBrasil());

            servicoAluguel.ProcessarFatura(alugelCarro);

            Console.WriteLine("");
            Console.WriteLine("FATURA");
            Console.WriteLine(alugelCarro.Fatura.ToString());
        }
    }
}
