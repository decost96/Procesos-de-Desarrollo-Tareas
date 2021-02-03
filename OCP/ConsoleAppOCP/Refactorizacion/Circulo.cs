namespace ConsoleAppOCP.Refactorizacion
{
    internal class Circulo.IArea
    {
       public double Radio { get; internal set; }

    public double Area => Math.PI * Math.Pow(this.Radio, 2);
}
}