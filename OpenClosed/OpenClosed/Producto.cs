using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    class Producto
    {
        //private string nombre;
        //private int categoria;
        //private double precio;

        //public string Nombre { get => nombre; set => nombre = value; }
        //public int Categoria { get => categoria; set => categoria = value; }
        //public double Precio { get => precio; set => precio = value; }

        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, int categoria, double precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }

        public override string ToString()
        {
            return String.Format("El producto {0} cuesta {1} ", Nombre, Precio);
        }
    }
}
