using System;

namespace ConsoleAppOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            Triangulo triangulo = new Triangulo();
            {
                triangulo.Base = 10;
                triangulo.Altura = 5;
            }
            Console.WriteLine("El Area del triangulo es: {0}", calculadora.CalcularArea(triangulo));

            Cuadrado cuadrado = new Cuadrado();
            {
                cuadrado.Lado = 6;
            }
            Console.WriteLine("El Area del cuadrado es: {0}", calculadora.CalcularArea(cuadrado));

            Circulo circulo = new Circulo();
            {
                circulo.Radio = 5;
            }
            Console.WriteLine("El Area del circulo es: {0}", calculadora.CalcularArea(circulo));

            Rectangulo rectangulo = new Rectangulo();



            Refactorizacion.Pentagono pentagano = new Refactorizacion.Pentagono();
            pentagano.Lado = 7.2;
            pentagano.Altura = 6;
            Console.WriteLine("El Area del pentagono es: {0}", calculadora.CalcularArea(pentagano));


        }
    }
}