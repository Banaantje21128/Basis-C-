using System.Collections.Generic;
using System.Linq;

namespace opdr19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Klant> klanten = Klant.Initialiseer();

            var gesorteerdeKlanten = klanten.OrderBy(k => k.Naam);

            foreach (Klant klant in gesorteerdeKlanten)
            {
                Console.WriteLine(klant.Naam);
            }

            var gefilterdeKlanten = klanten.Where(k => k.Telefoonnummer > 612345);

            foreach (Klant klant in gefilterdeKlanten)
            {
                Console.WriteLine($"{klant.Naam} - {klant.Telefoonnummer:D10}");
            }

            Console.WriteLine($"Aantal klanten: {klanten.Count}");

            Klant? eersteKlant = klanten.FirstOrDefault(k => k.Naam == "Marijke");
            Console.WriteLine(eersteKlant is null
                ? "Eerste klant: niet gevonden"
                : $"Eerste klant: {eersteKlant.Naam}");
        }
    }
}
