


public class program
{
    public static void Main()
    {


        Console.WriteLine("Input some text for space counter.");
        string input = Console.ReadLine();
        Console.WriteLine($"The text has {Spacecount(input)} spaces.");




    }
    public static int Spacecount(string spaces)
    {

        int countspace = 0;

        for (int i = 0; i < spaces.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(spaces.Substring(i, 1)))
            {
                countspace++;
            }
        }
        return countspace;
    }
}
