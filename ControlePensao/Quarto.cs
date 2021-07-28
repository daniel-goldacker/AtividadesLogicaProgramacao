using System;
namespace ControlePensao
{
    public class Quarto
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Quarto(int numero, string nome, string email)
        {
            Numero = numero;
            Nome = nome;
            Email = email;
        }
    }
}
