using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            if (!double.TryParse(invoer, out double cijfer))
            {
                Console.WriteLine("Voer cijfers in.");
                continue;
            }

            cijfers.Add(cijfer);
        }

        if (cijfers.Count == 0)
        {
            Console.WriteLine("Er zijn geen cijfers ingevoerd.");
            return;
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