using System.Collections.Generic;

namespace DYISolidRefactor
{
    interface IAuditable
    {
        IEnumerable<Producto> ObtenerProducto(int Tipo);

    }
}
