using System;
namespace SistemaPedido.Entidades.Enumerador
{
    enum StatusPedido : int
    {
        PagamentoPendente = 0,
        EmProcessamento = 1,
        Enviado = 2,
        Entregue = 3
    }
}
