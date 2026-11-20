namespace Opdr17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[8];
            names[0] = "Piet";
            names[1] = "Klaas";
            names[2] = "Jan";
            names[3] = "Willma";
            names[4] = "Henry the 8th";
            names[5] = "Willem";
            names[6] = "Jantje";
            names[7] = "Annie";

            string keuze = "";

            try
            {
                Console.WriteLine("Kies een getal tussen 0 en 7:");
                keuze = Console.ReadLine();
                int keuzeNummer = Convert.ToInt32(keuze);
                Console.WriteLine("Keuze: {0}", names[keuzeNummer]);

                Console.WriteLine("De andere namen:");

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("Naam: {1}", i, names[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("{0} is geen geldig getal tussen 0 en 7.", keuze);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is een woord en is geen geldig getal.", keuze);
            }
        }
    }
}
