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

        public static void Triplica (ref double valor)
        {
            valor *= 3;
        }

        public static void Triplica(double valor, out double resultado)
        {
            resultado = valor * 3;
        }
    }
}
