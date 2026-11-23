using System.Collections.Generic;

namespace opdr19
{
    internal class Klant
    {
        public Klant(int id, string naam, int telefoonnummer)
        {
            Id = id;
            Naam = naam;
            Telefoonnummer = telefoonnummer;
        }

        public int Id { get; }
        public string Naam { get; }
        public int Telefoonnummer { get; }

        public static List<Klant> Initialiseer()
        {
            return new List<Klant>
            {
                new Klant(1, "Marijke", 612345678),
                new Klant(2, "Jan", 612345677),
                new Klant(3, "Tim", 612345666),
                new Klant(4, "Matt", 612345555),
                new Klant(5, "Jeff", 612344444)
            };
        }

        public void ToonGegevens()
        {
            Console.WriteLine($"Klant ID: {Id}");
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Telefoonnummer: {Telefoonnummer:D10}");
        }
    }
}
    
