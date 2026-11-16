namespace opdr6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geef je geboortedatum:");
            string geboortedatum = Console.ReadLine();

            DateTime datum = DateTime.Parse(geboortedatum);
            Console.WriteLine("Je geboortedatum is: {0}", datum);

            DateTime vandaag = DateTime.Now;
            TimeSpan leeftijd = vandaag - datum;
            int jaren = (int)(leeftijd.TotalDays / 365.25);
            Console.WriteLine("Je leeftijd is: {0} jaar", jaren);

        }
    }
}
