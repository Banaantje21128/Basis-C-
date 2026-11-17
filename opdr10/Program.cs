using System.Reflection.Metadata.Ecma335;

namespace opdr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine("i is nu " + i);
            }
            Console.ReadLine();
        }
    }
}
