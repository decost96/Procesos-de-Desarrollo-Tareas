using System;
using Entity;
using DataAccessLayer;
using Interfaces;
//using System.ComponentModel.Composition;
//using System.Composition;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Inversion de Control");

            var estudiante = new Estudiante
            {
                Nombre = "Albert",
                Apellido= "Einstein"
            };

            //IGrabador  persistencia = new PersistenciaCsv();
            IGrabador persistencia = new PersistenciaJson(); // = new Persistencia();
            if (persistencia.Grabar(estudiante))
                Console.WriteLine("Se grabo");
        }
    }
}
