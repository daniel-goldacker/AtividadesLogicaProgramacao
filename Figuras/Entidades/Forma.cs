using System;
using Figuras.Enumerado;

namespace Figuras.Entidades
{
    abstract class Forma
    {
        public Cor Cor { get; set; }

        public Forma(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
