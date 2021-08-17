using System;
using System.Collections.Generic;
using System.Text;

namespace UtilizandoENUM.Enumerador
{
    enum StatusPedido : int
    {
        PagamentoPendente = 0,
        Processando = 1,
        ValorEnviado = 2,
        ValorEntregue = 3
    }
}
