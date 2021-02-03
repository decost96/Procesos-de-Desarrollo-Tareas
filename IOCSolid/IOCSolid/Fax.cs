using System;
using System.Collections.Generic;
using System.Text;

namespace IOCSolid
{
    class Fax : IFax
    {
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
}
