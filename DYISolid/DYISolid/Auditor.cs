using System;
using System.Collections.Generic;
using System.Text;

namespace DYISolid
{
    class Auditor
    {
        private Almacen miAlmacen;

        public Auditor()
        {
        }

        public Auditor(Almacen almacen)
        {
            miAlmacen = almacen;
        }

        public double TotalAlimentos()
        {
            double total = 0;

            foreach (Producto p in miAlmacen.Inventario)
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
