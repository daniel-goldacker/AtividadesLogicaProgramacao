using System;
namespace UtilizandoEnumCoposicao.Entities
{
    public class ContratoHoras
    {

        public DateTime Data { get; set; }
        public double ValorPorHoras { get; set; }
        public int Horas { get; set; }

        public ContratoHoras()
        {
        }

        public ContratoHoras(DateTime data, double valorPorHoras, int horas)
        {
            Data = data;
            ValorPorHoras = valorPorHoras;
            Horas = horas;
        }


        public double totalValor()
        {
            return ValorPorHoras * Horas;
        }
    }
}
