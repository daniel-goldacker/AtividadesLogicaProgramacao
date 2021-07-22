using System;

namespace CalculaHorasTrabalhadasFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe o valor hora do funcionário: ");
            funcionario.ValorHora = double.Parse(Console.ReadLine());

            /* Utilizando métodos estaticos */ 
            while (Validacoes.ValorEhNegativoOuZero(funcionario.ValorHora))
            {
                Console.WriteLine("Valor negativo ou zero.");
                Console.WriteLine("");
                Console.Write("Informe o valor hora do funcionário: ");
                funcionario.ValorHora = double.Parse(Console.ReadLine());
            }

            Console.Write("Informe as horas trabalhadas: ");
            funcionario.HorasTrabalhadas = double.Parse(Console.ReadLine());

            /* Utilizando métodos estaticos */
            while (Validacoes.ValorEhNegativoOuZero(funcionario.HorasTrabalhadas))
            {
                Console.WriteLine("Valor negativo ou zero.");
                Console.WriteLine("");
                Console.Write("Informe as horas trabalhadas: ");
                funcionario.HorasTrabalhadas = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0}, você trabalhou {1} horas com um valor hora de R$ {2} recebendo um total de R$ {3:F2}.", funcionario.Nome, funcionario.HorasTrabalhadas, funcionario.ValorHora, funcionario.CalculaSalario());
        }
    }
}
