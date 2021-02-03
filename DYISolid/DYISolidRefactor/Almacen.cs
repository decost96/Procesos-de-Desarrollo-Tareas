using System;
using System.Collections.Generic;
using System.Text;

namespace DYISolidRefactor
{
    class Almacen : IAuditable
    {
        private List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionaProducto(Producto Producto)
        {
            inventario.Add(Producto);
            Console.WriteLine("Adicionamos {0}", Producto.Nombre);
        }

        public IEnumerable<Producto> ObtenerProducto(int Tipo)
        {
            List<Producto> encontrado = new List<Producto>();

            foreach (Producto p in inventario)
            {
                if (p.Tipo == Tipo)
                    encontrado.Add(p);
            }

            return encontrado;
        }
    }
}
