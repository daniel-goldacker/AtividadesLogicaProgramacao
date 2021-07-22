using System;
namespace CalculaHorasTrabalhadasFuncionario
{
    public class Funcionario
    {

        public string Nome;
        public double ValorHora;
        public double HorasTrabalhadas;


        public double CalculaSalario()
        {
            return ValorHora * HorasTrabalhadas;
        }
    }
}


