using System;

namespace UtilizandoTryCath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o valor 1: ");
                int valor1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor 2: ");
                int valor2 = int.Parse(Console.ReadLine());

                int resultado = valor1 / valor2;
                Console.WriteLine("");
                Console.Write("Valor: {0}", resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERRO: Não é permitido divisão por zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("ERRO: Erro na formatação ({0})", e.Message);
            }
        }
    }
}
