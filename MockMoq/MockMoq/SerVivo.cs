using System;
using System.Collections.Generic;
using System.Text;

namespace MockMoq
{
    class SerVivo : ISerVivo
    {
        public string Nombre { get ; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }

        internal void Creador(string nombre, int edad, string especie)
        {
            nombre = Nombre;
            edad = Edad;
            especie = Especie;
            string mensaje = "Mi nombre es: " + nombre + ". tengo " + edad + ". años de edad y soy un " + especie + ".";
        }
    }
}

