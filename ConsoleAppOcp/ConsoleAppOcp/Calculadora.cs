using System;

namespace ConsoleAppOcp
{
    class Calculadora
    {
        public double CalcularArea(object figura) 
        { 
            if(figura.GetType() == typeof(Triangulo))
            {
                var triangulo = (Triangulo)figura;
                return triangulo.Base * triangulo.Altura / 2;
            }
            else if(figura.GetType() == typeof(Cuadrado))
            {
                var cuadrado = (Cuadrado)figura;
                return Math.Pow((double)cuadrado.Lado, 2);
            }
            else if (figura.GetType() == typeof(Cuadrado))
            {
                var circulo = (Circulo)figura;
                return Math.PI* Math.Pow(circulo.Radio, 2);
            }
            throw new ArgumentException("Tipo de figura no implementada");
        }
    }
}
