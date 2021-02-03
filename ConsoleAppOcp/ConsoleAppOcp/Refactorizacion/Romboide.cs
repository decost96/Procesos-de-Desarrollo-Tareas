using System;

namespace ConsoleAppOcp.Refactorizacion
{
    internal class Romboide : IArea
    {
        public double Base { get; internal set; }
        public double Altura { get; internal set; }

        public double Area()
        {
            return Base * Altura;
        }
    }
}