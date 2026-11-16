using System.ComponentModel.Design;

namespace opdr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo toets = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Key: " + toets.Key);
            string fout = toets.KeyChar.ToString();
            string GeenCijfer = "Geen cijfer!";

            if (toets.Key == ConsoleKey.D5)
            {
                Console.WriteLine("Correct! Mijn geluksgetal is 5!");
            }
            else if (toets.KeyChar < '0' || toets.KeyChar > '9')
            {
                Console.WriteLine(GeenCijfer);

                Console.WriteLine("Incorrect! {0} is niet juist.", fout);

                
            }

            

            
        }
    }
}
