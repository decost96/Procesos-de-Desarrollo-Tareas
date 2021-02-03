using System;
using System.Collections.Generic;
using System.Text;

namespace DYISolid
{
    class Producto
    {
        private string nombre;
        private int tipo; // 0 alimento, 1 medicina, 2 ropa
        private double precio;




        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public double Precio { get => precio; set => precio = value; }


        public Producto(string Nombre, int Tipo, double Precio)
        {
            nombre = Nombre;
            tipo = Tipo;
            precio = Precio;
        }

        public override string ToString()
        {
            string stringTipo = "";
            if (tipo == 0)
                stringTipo = "Alimento";
            else if (tipo == 1)
                stringTipo = "Medicina";
            else if (tipo == 2)
                stringTipo = "Ropa";

            return string.Format("{0}, tipo{1}, precio{2}", nombre, stringTipo, precio);
        }
    }
}
