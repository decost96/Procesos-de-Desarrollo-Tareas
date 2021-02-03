using System;

namespace ConsoleAppOcp.Refactorizacion
{
    internal class Cuadrado : IArea
    {
        public double Lado { get; internal set; }

        public double Area()
        {
            return Math.Pow((double)this.Lado, 2);
        }
    }
}