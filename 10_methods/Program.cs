
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