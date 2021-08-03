using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exemplo usando params");
            Console.WriteLine(Calculadora.Soma(new double[]{1,2,3}));
            Console.WriteLine(Calculadora.Soma(3, 2, 3 )); /* colocando o params na frente do vetor no método da classe não necessita 
                                                            * instanciar um vetor e passar como parâmetro, conforme exemplo acima */
            double valor, resultado;
            

            valor = 10;
            Console.WriteLine("");
            Console.WriteLine("Exemplo usando ref");
            Console.WriteLine(valor);
            Calculadora.Triplica(ref valor); /* colocando o ref na frente da variável do método da classe ela faz referência a variável 
                                              * original permitindo um método void alterar o valor e devolver o valor alterado para a 
                                              * variável de origem */
            Console.WriteLine(valor);


            valor = 10;
            resultado = 0;
            Console.WriteLine("");
            Console.WriteLine("Exemplo usando out");
            Console.WriteLine(valor);
            Console.WriteLine(resultado);
            Calculadora.Triplica(valor, out resultado); /* colocando o out na frente da variável do método da classe ela permite um 
                                                         * método void devolver o resultado em um parâmetro da classe declarado com out */
            Console.WriteLine(valor);
            Console.WriteLine(resultado);

            /* O REF e o OUT devem ser evitados dentro do programa (Não são considerados uma boa pratica) */

        }
    }
}
