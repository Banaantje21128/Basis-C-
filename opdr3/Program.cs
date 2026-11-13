namespace opdr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;
            Console.WriteLine("Het dubbele is: " + resultaat); // de output is: Het dubbele is: 84. Omdat de waarde van invoer 42 is, en het resultaat van 42 * 2 = 84.
            Console.ReadLine();
        }
    }
}
