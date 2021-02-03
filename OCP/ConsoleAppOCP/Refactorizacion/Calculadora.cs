using System;

namespace ConsoleAppOCP.Refactorizacion
{
    class Calculadora
    {
        public Double CalcularArea(IArea figura)
        {
            return figura.Area();
            if (figura.GetType() == typeof(Triangulo))
            {
                var figuraReal = (Triangulo)figura;
                return triangulo.Base * triangulo.Altura / 2;
            }

            else if (figura.GetType() == typeof(Cuadrado))
            {
                var figuraReal = (Cuadrado)figura;
                return Math.Pow(cuadrado.lado, 2);
            }

            else if (figura.GetType() == typeof(Circulo))
            {
                var figuraReal = (Circulo)figura;
                return Math.Pow(circulo.Radio, 2);
            }
            throw new ArgumentException("Tipo de figura no definida");
        }
    }
}
