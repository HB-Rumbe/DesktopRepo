
<<<<<<< HEAD
public class Program {


public static void Main(){
    PrintPerson();
    PrintPerson("Jason Doe", 18);
    PrintPerson("Jaon Doe", 82);

}

public static void PrintPerson(string name = "adad", int age = 16){
    Console.WriteLine($"{name} is {age} years old");
}

}
=======


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
>>>>>>> 1d15f0d00a95c84ebd3f4d3c6b2dc8906c602e1b
