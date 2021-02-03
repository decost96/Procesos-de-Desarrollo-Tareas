using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Refactorizacion
{
    class CInventarioAlimentos : CBaseInventario
    {
        public CInventarioAlimentos(CProducto pProducto) : base(pProducto)
        {

        }

        public override double CalcularProducto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            producto.Precio *= 0.20 ;
            return producto.Precio;
        }
    }
}
