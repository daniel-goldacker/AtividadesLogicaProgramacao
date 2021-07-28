using System;
namespace Calculadora
{
    public class Calculadora
    {

        public static double Soma(params double[] numeros)
        {
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }
    }
}
