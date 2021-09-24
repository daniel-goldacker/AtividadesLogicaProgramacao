using System;
namespace ContaBancara.Entidade.Excecao
{
    class DominioExcecao : ApplicationException
    {
        public DominioExcecao(string mensagem) : base(mensagem)
        {

        }
    }
}
