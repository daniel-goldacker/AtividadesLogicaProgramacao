using System;
using ReservaQuarto.Entidade.Excecao;

namespace ReservaQuarto
{
    public class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public Reserva(int numeroQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            NumeroQuarto = numeroQuarto;

            AtualizaDatas(dataEntrada, dataSaida);
        }

        public int Duracao()
        {
            return (int)DataSaida.Subtract(DataEntrada).TotalDays;
        }

        public void AtualizaDatas(DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataEntrada < DateTime.Now || dataSaida < DateTime.Now)
            {
                throw new DominioExcecao("Datas da reserva não podem ser menores que a data atual.");
            }

            if (dataEntrada >= dataSaida)
            {
                throw new DominioExcecao("A data de saida não pode ser manor que a data de entrada.");
            }

            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public override string ToString()
        {
            return "Número do Quarto: " + NumeroQuarto
                + ", Data Entrada: " + DataEntrada.ToString("dd/MM/yyyy")
                + ", Data Saida: " + DataSaida.ToString("dd/MM/yyyy")
                + ", " + Duracao() + " noites.";
        }
    }
}
