using System.Reflection.Metadata.Ecma335;

namespace opdr11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool KeepRunning = true;

            Console.WriteLine("1 = Menu 1");
            Console.WriteLine("2 = Menu 2");
            Console.WriteLine("3 = Afsluiten");

            while (KeepRunning == true)
            {
                

                ConsoleKeyInfo toets = Console.ReadKey();
                Console.WriteLine();

                if (toets.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Menu 1");
                }
                else if (toets.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Menu 2");
                }
                else if (toets.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Afsluiten");
                    KeepRunning = false;
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze voer 1, 2 of 3 voor afsluiten.");
                }   
            }

        }
        
    }
}
