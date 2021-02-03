using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    class CTienda
    {
        private List<CBaseInventario> productos;

        public CTienda(List<CBaseInventario> pProductos)
        {
            productos = pProductos;
        }

        public void calcularInventario()
        {
            double total = 0;



            //foreach (CProducto producto in productos)
            //{
            //    Console.WriteLine(producto);
            //    total += producto.Precio;
            //}

            foreach (var actual in productos)
            {
                Producto producto = actual as Producto; 
                if (producto.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    producto.Precio *= 0.12;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
                if (producto.Categoria == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    producto.Precio *= 0.12;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }

                Console.WriteLine("El total en inventario es {0}", total);

            }
        }

    }
}