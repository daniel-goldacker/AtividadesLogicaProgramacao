using System;

namespace UtilizandoVariaveisNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> v1 = null; // forma de dizer que v1 pode se null
            double? v2 = 10.0; // Forme simplificada de dizer que v2 pode se null

            // Operador de coalecência nula
            double? v3 = v1 ?? 99;  // se v1 for null abribui o valor 99
            double? v4 = v2 ?? 999; // se v2 for null abribui o valor 999


            Console.WriteLine(v1.GetValueOrDefault()); // Imprime o valor da variável v1 ou o Default(0)
            Console.WriteLine(v2.GetValueOrDefault()); // Imprime o valor da variável v2 ou o Default(0)

            Console.WriteLine("");

            Console.WriteLine(v1.HasValue); // Se o valor de v1 for null retorna False, senão é True
            Console.WriteLine(v2.HasValue); // Se o valor de v2 for null retorna False, senão é True

            Console.WriteLine("");

            if (v1.HasValue)
            { 
                Console.WriteLine(v1.Value); // Imprime o valor da variável v1, se for null da erro na aplicação
            }
            else
            {
                Console.WriteLine("v1 is null");
            }

            if (v2.HasValue)
            {
                Console.WriteLine(v2.Value); // Imprime o valor da variável v2, se for null da erro na aplicação
            }
            else
            {
                Console.WriteLine("v2 is null");
            }

            Console.WriteLine("");         
            Console.WriteLine(v3);
            Console.WriteLine(v4); 
        }
    }
}