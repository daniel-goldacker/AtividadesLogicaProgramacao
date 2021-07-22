using System;
namespace CalculaHorasTrabalhadasFuncionario
{
    public class Validacoes
    {

        public static bool ValorEhNegativoOuZero(double numero)
        {
            bool valorEhNegativoOuZero = false;

            if (numero <= 0)
            {
                valorEhNegativoOuZero = true;
            }

            return valorEhNegativoOuZero;
        }
    }
}
