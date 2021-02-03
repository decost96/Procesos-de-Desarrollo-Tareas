using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    class CInventarioAlimentos : CBaseInventario
    {
        public CInventarioAlimentos(CProducto pProducto) : base(pProducto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.12;
            return producto.Precio;
        }
    }
}
