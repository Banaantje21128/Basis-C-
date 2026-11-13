namespace opdr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam;
            Console.WriteLine("Wat is je naam?");
            naam = Console.ReadLine();

            Console.WriteLine("Welkom " + naam + "!");
            Console.ReadLine();
        }
    }
}
