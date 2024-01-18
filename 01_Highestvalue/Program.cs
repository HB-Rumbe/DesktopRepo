int[] array = new int[10];
Random rnd = new Random();
string yessir;
int numberofattempts = 1;
Console.Clear();
Console.WriteLine("Please Input a number with less than 4 digits.");
while (true)
{
    yessir = Console.ReadLine()!;
    if (yessir.Length < 4)
    {
        break;
    }
    else
    {  
        Console.Clear();
        Console.WriteLine("That input is not below 4 digits! Try again."+"("+numberofattempts+")");
        numberofattempts++;
    }
}
Console.Clear();
Console.WriteLine("This was your input: " + yessir);
Console.Write("These are the random numbers: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 9);

    Console.Write(array[i] + " ");
}
int substring1 = Convert.ToInt32(yessir.Substring(0, 1));
int substring2 = Convert.ToInt32(yessir.Substring(1, 1));
int substring3 = Convert.ToInt32(yessir.Substring(2, 1));
String numb;
if (array[substring1 - 1] > substring1)
{
    numb = Convert.ToString(array[substring1 - 1]);
    yessir = yessir.Remove(0, 1).Insert(0, numb);
}

if (array[substring2 - 1] > substring2)
{
    numb = Convert.ToString(array[substring2 - 1]);
    yessir = yessir.Remove(1, 1).Insert(1, numb);
}

if (array[substring3 - 1] > substring3)
{
    numb = Convert.ToString(array[substring3 - 1]);
    yessir = yessir.Remove(2, 1).Insert(2, numb);
}
Console.WriteLine("\n--------------------------------------------");
Console.WriteLine("The highest possible number is: " + yessir);
Console.ReadKey();