namespace opdr14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabel = { { 10, 20 }, { 30, 40 }, { 50, 60 } };

            Console.WriteLine(tabel[2, 1]);
            Console.WriteLine(tabel[0, 0] + tabel[1, 1]);

            //Dit is een 2 deimensionale array, de eerste index is de rij, de tweede index is de kolom.
        }
    }
}
