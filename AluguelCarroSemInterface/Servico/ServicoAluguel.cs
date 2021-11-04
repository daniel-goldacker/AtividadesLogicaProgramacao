using System;

namespace AluguelCarroSemInterface.Servico
{
    public class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private TaxaServicoBrasil _taxaServicoBrasil = new TaxaServicoBrasil();

        public ServicoAluguel(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void ProcessarFatura(AlugelCarro alugelCarro)
        {
            TimeSpan duracao = alugelCarro.DataDevolucao.Subtract(alugelCarro.DataRetirada);

            double pagamentoBasico = 0;

            if(duracao.TotalHours <= 12)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            alugelCarro.Fatura = new Fatura(pagamentoBasico, _taxaServicoBrasil.Taxa(pagamentoBasico));
        }
    }
}
