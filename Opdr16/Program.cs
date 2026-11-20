using System.Reflection.Metadata.Ecma335;

namespace Opdr16
{
    internal class Program
    {
        public double optellen(double getal1, double getal2)
        {
            return getal1 + getal2;
        }
        public double vermenigvuldigen(double getal1, double getal2)
        {
            return getal1 * getal2;
        }
        public double delen(double getal1, double getal2)
        {
            return getal1 / getal2;
        }
        public double aftrekken(double getal1, double getal2)
        {
            return getal1 - getal2;
        }
        static void Main(string[] args)
        {

            bool KeepRunning = true;

            Console.WriteLine("Kies een bewerking:");
            Console.WriteLine("1. Optellen & aftrekken");
            Console.WriteLine("2. Optellen & Vermenigvuldigen");
            Console.WriteLine("3. Optellen & Delen");
            Console.WriteLine("4. Afsluiten");


            while (KeepRunning == true)
            {
                ConsoleKeyInfo toets = Console.ReadKey();
                Console.WriteLine();
                if (toets.Key == ConsoleKey.D1)
                {
                    Program p = new Program();
                    Console.WriteLine("Vul nu de eerste getal in:");
                    double getal1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Vul nu de tweede getal in:");
                    double getal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dit is optellen: " + p.optellen(getal1, getal2));
                    Console.WriteLine("Dit is aftrekkend: " + p.aftrekken(getal1, getal2));
                    
                    
                }
                else if (toets.Key == ConsoleKey.D2)
                {
                    Program p = new Program();
                    Console.WriteLine("Vul nu de eerste getal in:");
                    double getal1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Vul nu de tweede getal in:");
                    double getal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dit is optellen: " + p.optellen(getal1, getal2));
                    Console.WriteLine("Dit is vermenigvuldigen: " + p.vermenigvuldigen(getal1, getal2));
                }
                else if (toets.Key == ConsoleKey.D3)
                {
                    Program p = new Program();
                    Console.WriteLine("Vul nu de eerste getal in:");
                    double getal1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Vul nu de tweede getal in:");
                    double getal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dit is optellen: " + p.optellen(getal1, getal2));
                    Console.WriteLine("Dit is delen: " + p.delen(getal1, getal2));
                }
                else if (toets.Key == ConsoleKey.D4)
                {
                    KeepRunning = false;
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze voer 1, 2, 3 of 4 in voor afsluiten.");
                }
            }
        }






    }
}