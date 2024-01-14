
int length = 4;
Console.Clear();
Console.WriteLine($"Enter a word with less than {length} letters.");

int z = 1;
Random rnd = new Random();
string random = "";
char[] bogstaver =
{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
string input;
int n = 0;

while (true)
{
    input = Console.ReadLine();
    bool dad = true;

    foreach (char bogstav in input)
    {
        if (!bogstaver.Contains(bogstav))
        {
            dad = false;
            break;
        }
    }

    if (input.Length < length + 1 && dad)
    {
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Input was not a word with less than {length} letters. Try again({z})");
        z++;
    }

}
DateTime before = DateTime.Now;
DateTime after;
while (true)
{
    random = "";
    for (int i = 0; i < input.Length; i++)
    {
        char scooby = bogstaver[rnd.Next(25)];
        random += scooby;
    }
    n++;
    if (input == random)
    {
        after = DateTime.Now;
        break;
    }
    Console.Write(random + " ");
}
TimeSpan elapsed = after - before;
Console.WriteLine($"{random}\n\nAfter {n} attempts and " + Math.Round(elapsed.TotalSeconds, 2) + " seconds we found your input.");

Console.WriteLine("That's " + Math.Round(n / elapsed.TotalSeconds, 0) + " attemps per second.\n");
Console.ReadKey();
