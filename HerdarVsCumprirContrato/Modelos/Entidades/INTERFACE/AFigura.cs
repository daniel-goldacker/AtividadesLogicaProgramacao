using System;
using HerdarVsCumprirContrato.Modelos.Entidades.INTERFACE;
using HerdarVsCumprirContrato.Modelos.Enums;

namespace HerdarVsCumprirContrato.Modelos.Entidades.INTERFACE
{
    abstract class AFigura : IFigura
    {
        public Cor Cor { get; set; }

        public abstract double Area();
    }
}
