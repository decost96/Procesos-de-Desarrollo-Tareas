using System;

namespace LiskovRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal noticiero = new Noticiero("Hola todos");
            noticiero.Muestra();

            Principal radio = new Radio("como estan?");
            noticiero.Muestra();
        }
    }
}
