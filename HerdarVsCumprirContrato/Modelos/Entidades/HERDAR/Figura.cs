using System;
using HerdarVsCumprirContrato.Modelos.Enums;

namespace HerdarVsCumprirContrato.Modelos.Entidades.HERDAR
{
    abstract class Figura
    {
        public Cor Cor { get; set; }

        public abstract double Area();
    }

}
