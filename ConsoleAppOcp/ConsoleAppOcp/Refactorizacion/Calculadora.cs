using System;

namespace ConsoleAppOcp.Refactorizacion
{
    class Calculadora
    {
        public double CalcularArea(IArea figura) 
        {
            return figura.Area();
        }
    }
}
