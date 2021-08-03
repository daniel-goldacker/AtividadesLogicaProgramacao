using System;

namespace UtilizandoBoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boxing");
            int variavel = 10;
            Object obj = variavel; /* Boxing: Conversão de um objeto tipo valor para um objeto tipo referência compativel
                                    * (De um valor que fica na memória STACK para um que fica na HEAP) */
            Console.WriteLine(obj);

            Console.WriteLine("");

            Console.WriteLine("UnBoxing");
            Object outroObj = 20;
            int outraVariavel = (int) outroObj; /* UnBoxing: Conversão de um  objeto tipo referência para um objeto tipo valor compativel
                                                 * (De um valor que fica na memória HEAP para um que fica na STACK) */
            Console.WriteLine(outroObj);
        } 
    }
}
