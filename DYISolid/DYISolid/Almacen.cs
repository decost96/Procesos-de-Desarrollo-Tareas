using System;
using System.Collections.Generic;
using System.Text;

namespace DYISolid
{
    class Almacen
    {
        private List<Producto> invetario;
        public List<Producto> Inventario { get => invetario; set => invetario = value; }

        public Almacen()
        {
            invetario = new List<Producto>();
        }

        public void AdicionaProducto(Producto Producto)
        {
            invetario.Add(Producto);
            Console.WriteLine("Adicionamos {0}", Producto.Nombre);
        }
    }
}
