using System;

namespace Models
{

    public abstract class Pieza
    {
        public abstract decimal Area();

        protected abstract decimal Perimetro();
        public bool EjemploMetodo()
        {
            return false;
        }

        public int ValorNatural = 1;
    }
}
