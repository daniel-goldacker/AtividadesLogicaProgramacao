using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Calculadora.Soma(new double[]{1,2,3}));

            Console.WriteLine(Calculadora.Soma(3, 2, 3 )); /* colocando o params na frente do vetor no método da classe não necessita 
                                                            * intanciar um vetor e passar como parâmetro, conforme exemplo acima */
        }
    }
}
