using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> cijfers = new List<double>();

        while (true)
        {
            Console.Write("Voer een cijfer in of typ stop: ");
            string invoer = Console.ReadLine();

            if (invoer.ToLower() == "stop")
            {
                break;
            }
            else if (!double.TryParse(invoer, result: out double cijfer) || cijfer < 0 || cijfer > 10)
                    
            {
                Console.WriteLine("Ongeldige invoer. Voer een cijfer tussen 0 en 10 in.");
                continue;
            }

            if (cijfers.Count == 0)
            {
                Console.WriteLine("Er zijn geen cijfers ingevoerd.");
                return;
            }      
            double cijfer = double.Parse(invoer);
            cijfers.Add(cijfer);
        }

        Console.WriteLine($"Gemiddelde: {cijfers.Average()}");
        Console.WriteLine($"Hoogste: {cijfers.Max()}");
        Console.WriteLine($"Laagste: {cijfers.Min()}");

        int aantalVoldoendes = cijfers.Where(c => c >= 5.5).Count();
        Console.WriteLine($"Aantal voldoendes: {aantalVoldoendes}");

        Console.WriteLine("Van hoog naar laag:");

        foreach (double c in cijfers.OrderByDescending(c => c))
        {
            Console.WriteLine(c);
        }
    }
}