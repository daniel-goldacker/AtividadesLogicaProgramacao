using System;
namespace UtilizandoEnumCoposicao.Entities
{
    public class Departamento
    {
        public string nome { get; set; }

        public Departamento()
        { 
        }

        public Departamento(string nome)
        {
            this.nome = nome;
        }
    }
}
