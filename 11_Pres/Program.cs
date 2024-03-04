using System.Numerics;
public class Program
{
    public static void Main()
    {

        Start();

    }

    public static void Start()
    {
        Console.Clear();
        Console.WriteLine("Which program do you want to run?");
        Console.WriteLine("1: For loops");
        Console.WriteLine("2: For loops with big integer");
        Console.WriteLine("3: Foreach loops");
        Console.WriteLine("4: Foreach loops with lists");


        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                Forloops();
                break;

            case "2":
                Console.Clear();
                ForloopsBigInt();
                break;

            case "3":
                Console.Clear();
                ForeachLoops();
                break;

            case "4":
                Console.Clear();
                ForEachLoopsWithList();
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid input");
                Start();
                break;
        }
    }
    public static void Forloops()
    {

        Console.Clear();
        Console.WriteLine("Which Iteration value do you want to see?");
        int iteration = Convert.ToInt32(Console.ReadLine());
        int iterationcount = 3;
        long a = 1;
        long b = 1;
        long sum = 0;
        Console.Clear();
        Console.WriteLine("0\n");
        Console.WriteLine(a + "\n");
        Console.WriteLine(b + "\n");

        for (int i = 0; i < iteration - 3; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
            Console.WriteLine(sum);
            Console.WriteLine();
            iterationcount++;

        }
        Console.WriteLine($"Iteration {iterationcount}'s value is {sum}");
    }

    public static void ForloopsBigInt()
    {
        Console.Clear();
        Console.WriteLine("Which Iteration value do you want to see?");
        int iteration = Convert.ToInt32(Console.ReadLine());
        int iterationcount = 3;
        BigInteger a = 1;
        BigInteger b = 1;
        BigInteger sum = 0;
        Console.Clear();
        Console.WriteLine("0\n");
        Console.WriteLine(a + "\n");
        Console.WriteLine(b + "\n");

        for (int i = 0; i < iteration - 3; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
            Console.WriteLine(sum);
            Console.WriteLine();
            iterationcount++;

        }
        Console.WriteLine($"Iteration {iterationcount}'s value is {sum}");
    }

    public static void ForeachLoops()
    {
        Console.Clear();
        int lowercase = 0;
        int uppercase = 0;
        int neither = 0;
        Console.WriteLine("Please enter a string.");
        string input = Console.ReadLine();
        Console.WriteLine("\n");
        foreach (char a in input)
        {
            if (a == Char.ToLower(a))
            {
                lowercase++;
            }
            else if (a == Char.ToUpper(a))
            {
                uppercase++;
            }
            else
            {
                neither++;
            }
        }
        
        char[] lowercasesarray = new char[lowercase];
        char[] uppercasesarray = new char[uppercase];
        char[] neitherarray = new char[neither];
        int lowervalue = 0;
        int uppervalue = 0;
        int neithervalue = 0;
        foreach (char a in input)
        {
            if (a == Char.ToLower(a))
            {
                lowercasesarray[lowervalue] = a;
                lowervalue++;
            }
            else if (a == Char.ToUpper(a))
            {
                uppercasesarray[uppervalue] = a;
                uppervalue++;
            }
            else
            {
                neitherarray[neithervalue] = a;
                neithervalue++;
            }
        }

        Console.WriteLine($"There are {lowervalue} lowercase letters, {uppervalue} uppercase letters and {neither} that were neither in the array.");

        Console.Write("Here are the lowercase letters:");
        foreach (char a in lowercasesarray)
        {

            Console.Write(a + " ");
        }
        Console.Write("\nHere are the uppercase letters:");
        foreach (char a in uppercasesarray)
        {
            Console.Write(a + " ");
        }
        Console.Write("\nHere are the rest:");
        foreach (char a in neitherarray)
        {
            Console.Write(a + " ");
        }

    }
    public static void ForEachLoopsWithList()
    {
        Console.Clear();
        int lowercase = 0;
        int uppercase = 0;
        char[] Letters = { 'h', 'B', 'B', 'z', 'F', 'X', 'e', 'w', 'T', 'w', 'R', 'z', 'k', 'e', 'Y', 'q', 'A', 'Z', 'f', 'I', 'r', 'R', 'M', 'b', 'M', 'P', 'z', 'F', 'U', 'e' };
        List<char> LowerCase = new List<char>();
        List<char> UpperCase = new List<char>();
        foreach (char a in Letters)
        {
            if (a == Char.ToLower(a))
            {
                LowerCase.Add(a);
                lowercase++;
            }
            else
            {
                UpperCase.Add(a);
                uppercase++;
            }
        }

        Console.WriteLine($"There are {lowercase} lowercase letters and {uppercase} uppercase letters in the array.");

        Console.Write("Here are the lowercase letters:");
        foreach (char a in LowerCase)
        {

            Console.Write(a + " ");
        }
        Console.Write("\nHere are the uppercase letters:");
        foreach (char a in UpperCase)
        {
            Console.Write(a + " ");
        }

    }
}