namespace Opdr15
{
    internal class Program
    {
        public int optellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
        static void  Main(string[] args)
        {
            Program p = new Program();
            p.optellen(5, 10);
            Console.WriteLine("De som is en het antwoord is: " + p.optellen(5, 10));
            Console.ReadLine();
        }
    }
}
