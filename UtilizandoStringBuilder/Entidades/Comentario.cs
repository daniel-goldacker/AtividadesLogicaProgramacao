using System;
namespace UtilizandoStringBuilder.Entidades
{
    public class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        {
        }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
