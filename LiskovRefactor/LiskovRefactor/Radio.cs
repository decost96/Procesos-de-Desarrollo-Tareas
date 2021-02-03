using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovRefactor
{
    class Radio : Principal
    {
        public Radio(string Mensaje) : base(Mensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
        }
    }
}
