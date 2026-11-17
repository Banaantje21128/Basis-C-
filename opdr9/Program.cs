using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace opdr9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Kies: 1 = Small, 2= Medium, 3 = Large:");
            int keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("Small = 2,00");
                    break;
                case 2:
                    Console.WriteLine("Medium = 2,50");
                    break;
                case 3:
                    Console.WriteLine("Large = 3,00");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
            Console.ReadLine();
        }
    }
}
