using System;

namespace DYISolidRefactor
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Almacen miAlmacen = new Almacen();
            double total = 0;

            miAlmacen.AdicionaProducto(new Producto("Tomate", 0, 12.50));
            miAlmacen.AdicionaProducto(new Producto("Banana", 0, 15));
            miAlmacen.AdicionaProducto(new Producto("Analgesico", 1, 23.45));
            miAlmacen.AdicionaProducto(new Producto("Jeans", 2, 10));
            miAlmacen.AdicionaProducto(new Producto("Manzana", 0, 6.75));
            miAlmacen.AdicionaProducto(new Producto("AntiAcido", 1, 35));
            miAlmacen.AdicionaProducto(new Producto("Blusa", 2, 9));



            Console.WriteLine("--------");

            Auditor miAuditor = new Auditor(miAlmacen);
            total = miAuditor.TotalAlimentos();
            Console.WriteLine("El total de alimentos es {0}", total);
        }
    }
}
