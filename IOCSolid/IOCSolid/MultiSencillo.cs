using System;
using System.Collections.Generic;
using System.Text;

namespace IOCSolid
{
    class MultiSencillo : IMultiBasico
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografia");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo Documento");
        }
    }
}
