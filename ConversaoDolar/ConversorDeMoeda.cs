using System;
namespace ConversaoDolar
{
    public class ConversorDeMoeda
    {
        public static double RetonaValorReais(double cotacaoDolarHoje, double qtdDolarCompra)
        {
            return cotacaoDolarHoje * qtdDolarCompra;
        } 
    }
}
