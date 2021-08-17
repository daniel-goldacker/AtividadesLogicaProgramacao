using System;
using UtilizandoENUM.Enumerador;

namespace UtilizandoENUM.Entidades
{
    class Pedido
    {
        public string NumPedido { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return NumPedido + ", " + Momento + ", " + Status;
        }
    }
}
