using System;
namespace AluguelCarroSemInterface
{
    public class AlugelCarro
    {
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AlugelCarro(DateTime dataRetirada, DateTime dataDevolucao, Veiculo veiculo)
        {
            DataRetirada = dataRetirada;
            DataDevolucao = dataDevolucao;
            Veiculo = veiculo;
            Fatura = null;
        }


    }
}
