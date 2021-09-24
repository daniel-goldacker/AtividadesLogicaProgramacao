using System;
namespace ReservaQuarto.Entidade.Excecao
{
    class DominioExcecao : ApplicationException
    {
        public DominioExcecao(string mensagem) : base(mensagem)
        {

        }
    }
}
