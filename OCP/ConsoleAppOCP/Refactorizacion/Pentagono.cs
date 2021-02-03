namespace ConsoleAppOCP.Refactorizacion
{
    internal class Pentagono.IArea
    {
    public double Lado { get; internal set; }
    public double Altura { get; internal set; }

    public double Area()
    {
        return Math.PI * Math.Pow(this.Radio, 2);
    }

}
}