namespace opdr5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geef breedte:");
            double breedte = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef hoogte:");
            double hoogte = double.Parse(Console.ReadLine());

            double oppervlakte = breedte * hoogte;
            Console.WriteLine("De oppervlakte is: {0:F2}", oppervlakte);

        }
    }
}
