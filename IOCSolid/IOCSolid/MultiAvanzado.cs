using System;
using System.Collections.Generic;
using System.Text;

namespace IOCSolid
{
    class MultiAvanzado : IMultiCompleto
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografia");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo Documento");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }

        public void Faxear()
        {
            Console.WriteLine("Te envio un fax");
        }
    }
}
