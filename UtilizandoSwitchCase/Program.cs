using System;

namespace UtilizandoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sigla para estado(SC, RJ, RS e SP): ");
            string sigla = Console.ReadLine().ToUpper();

            switch (sigla)
            {
                case "SC":
                    Console.WriteLine("Santa Catarina");
                    break;
                case "RJ":
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case "RS":
                    Console.WriteLine("Rio Grande do Sul");
                    break;
                case "SP":
                    Console.WriteLine("São Paulo");
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}
