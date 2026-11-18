namespace opdr12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "Piet";
            names[1] = "Klaas";
            names[2] = "Jan";
            names[3] = "Willma";
            names[4] = "Henry the 8th";        

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
