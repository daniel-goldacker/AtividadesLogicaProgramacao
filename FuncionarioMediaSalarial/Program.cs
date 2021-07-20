using System;

namespace FuncionarioMediaSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Informe o nome do funcionário 1: ");
            funcionario1.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do funcionário 1: ");
            funcionario1.Salario = double.Parse(Console.ReadLine());

            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Informe o nome do funcionário 2: ");
            funcionario2.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do funcionário 2: ");
            funcionario2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Média Salarial: {0:F2}", (funcionario1.Salario + funcionario2.Salario)/2);
        }
    }
}
