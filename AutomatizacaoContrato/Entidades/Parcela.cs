using System;
namespace AutomatizacaoContrato.Entidades
{
    class Parcela
    {
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }
    }
}
