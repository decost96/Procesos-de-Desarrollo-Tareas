using System;

namespace ConsoleAppOcp.Refactorizacion
{
    internal class Triangulo : IArea
    {
        public double Base { get; internal set; }
        public double Altura { get; internal set; }

        public double Area()
        {
           return Base * Altura / 2;
        }
    }
}