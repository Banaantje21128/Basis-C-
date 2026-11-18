using System.Runtime.InteropServices.JavaScript;

namespace opdr13
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<int> getallenlijst = new List<int>();

            while (getallenlijst.Count < 5)
            {
                Console.WriteLine("Enter a number:");

                if (int.TryParse(Console.ReadLine(), out int getal))
                {
                    getallenlijst.Add(getal);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }
            Console.WriteLine("You entered the following numbers:");
            foreach (int num in getallenlijst)
            {
                Console.WriteLine(num);
            }
        }
    }
}