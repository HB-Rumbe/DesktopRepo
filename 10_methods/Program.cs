

using System.Numerics;
public class program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a number.");
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        Recursion(input);


    }
    static void Recursion(BigInteger input)
    {
        if (input >= 10)
        {
            Recursion(input / 10);
        }
        Console.Write(input % 10 + " ");



    }

}



