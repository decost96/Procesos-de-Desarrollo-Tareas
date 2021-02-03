using System;

namespace ConsoleAppOcp
{
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Areas!");

            Refactorizacion.Calculadora calculadora = new Refactorizacion.Calculadora();


            Refactorizacion.Triangulo triangulo = new Refactorizacion.Triangulo
            {
                Base = 10,
                Altura = 5
            };

            Console.WriteLine("El area del triangulo es: {0}", calculadora.CalcularArea(triangulo));

            Refactorizacion.Cuadrado cuadrado = new Refactorizacion.Cuadrado
            {
                Lado = 10
            };

       
            Console.WriteLine("El area del cuadrado es: {0}", calculadora.CalcularArea(cuadrado));


            Refactorizacion.Circulo circulo = new Refactorizacion.Circulo
            {
                Radio = 5
            };

            Console.WriteLine("El area del cuadrado es: {0}", calculadora.CalcularArea(circulo));


            Refactorizacion.Romboide romboide = new Refactorizacion.Romboide
            {
                Base = 7,
                Altura = 11
            };

            Console.WriteLine("El area del romboide es: {0}", calculadora.CalcularArea(romboide));
        }
    }
}
