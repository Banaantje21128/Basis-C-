namespace Opdr18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Auto auto2 = new Auto("Volvo");
            Auto auto3 = new Auto("Volvo", 24999.99);
        }
    }
}
