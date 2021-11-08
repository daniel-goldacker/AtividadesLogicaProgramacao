using System;
using AluguelCarroComInterface.Servico;

namespace AluguelCarroSemInterface.Servico
{
    class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxaServico _taxaServico;

        public ServicoAluguel(double precoPorHora, double precoPorDia, ITaxaServico itaxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = itaxaServico;
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

            alugelCarro.Fatura = new Fatura(pagamentoBasico, _taxaServico.Taxa(pagamentoBasico));
        }
    }
}
