using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovRefactor
{
    class Noticiero : Principal
    {
        public Noticiero(string Mensaje) : base(Mensaje)
        {

        }


        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje)
        }

    }
}
