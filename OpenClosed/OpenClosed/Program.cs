using System;
using System.Collections.Generic;

namespace OpenClosed.Refactorizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<CProducto> misProductos = new List<CProducto>
            //{
            //    new CProducto("Papas", 1, 12.5),
            //    new CProducto("Tomate", 1, 12.5),
            //    new CProducto("Mortadela", 2, 25),
            //    new CProducto("Lechuga", 1, 5),
            //    new CProducto("Salchicha", 2, 3)
            //};

            List<CBaseInventario> productos = new List<CBaseInventario>
            {
                new CInventarioAlimentos( new CProducto("Papas", 1, 12.5)),
                new CInventarioAlimentos( new CProducto("Tomate", 1, 32.5)),
                new CInventarioAlimentos( new CProducto("Mortadela", 1, 25)),
                new CInventarioAlimentos( new CProducto("Lechuga", 1, 5)),
                new CInventarioAlimentos(new CProducto("Salchicha", 1, 3))
            };

            CTienda miTienda = new CTienda(productos);
            miTienda.calcularInventario();
        }
    }
}
