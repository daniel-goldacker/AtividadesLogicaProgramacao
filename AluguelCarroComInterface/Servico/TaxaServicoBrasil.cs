using AluguelCarroComInterface.Servico;

namespace AluguelCarroSemInterface.Servico
{
    public class TaxaServicoBrasil : ITaxaServico
    {
       public double Taxa(double valor)
        {
            if (valor <= 100)
            {
                return valor * 0.2;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}
