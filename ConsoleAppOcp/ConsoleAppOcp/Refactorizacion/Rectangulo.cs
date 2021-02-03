using System;

namespace ConsoleAppOcp.Refactorizacion
{
    internal class Rombo : IArea
    {
        public double Base { get; internal set; }
        public double Altura { get; internal set; }

        public double Area()
        {
            return this.Base * this.Altura;
        }
    }
}