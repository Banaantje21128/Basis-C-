string input = Console.ReadLine();
input = input.ToUpper();
if (input == "LUCKY")
{
    Console.WriteLine("je typte 'Lucky' en dat is correct!");
}
else 
{
    Console.WriteLine("je typte '{0}' en dat is niet correct!", input);
}
Console.ReadLine();
