using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovRefactor
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string Mensaje)
        {
            mensaje = Mensaje;
        }

        public abstract void Muestra();
    }
}
