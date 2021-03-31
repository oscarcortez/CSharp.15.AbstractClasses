using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Cuadrado : Pieza
    {
        readonly decimal Lado;

        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public override decimal Area()
        {
            return Lado * Lado;
        }

        protected override decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}
