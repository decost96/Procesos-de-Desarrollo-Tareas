using System;

namespace SpecFlowTest.Features
{
    internal class Calculadora
    {
        public int PrimerNumero { get; internal set; }
        public int SegundoNumero { get; internal set; }
        public int Multiplicando { get; internal set; }
        public int Multiplicador { get; internal set; }
        public object Resultado { get; internal set; }

        internal void Sumar()
        {
            Resultado= PrimerNumero + SegundoNumero;
        }

        internal void Multiplicar()
        {
            Resultado = Multiplicando + Multiplicador;
        }
    }
}