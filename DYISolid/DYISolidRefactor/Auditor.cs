using System;
using System.Collections.Generic;
using System.Text;

namespace DYISolidRefactor
{
    class Auditor
    {
        private IAuditable miAlmacen;

        public Auditor(IAuditable Almacen)
        {
            miAlmacen = Almacen;
        }

        public double TotalAlimentos()
        {
            double total = 0;
            IEnumerable<Producto> listado = miAlmacen.ObtenerProducto(0);

            foreach (Producto p in listado)
            {
                if(p.Tipo == 0)
                {
                    Console.WriteLine(p);
                    total += p.Precio;

                }
            }
            return total;
        }
    }
}
