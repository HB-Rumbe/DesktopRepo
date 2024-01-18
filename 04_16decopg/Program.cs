
// opgave 1.1
int evennumbers = 0;
int oddnumbers = 0;
int numberofinputs = 0;

while (true)
{
    Console.Write("\nEnter a number: ");
    int input = Convert.ToInt32(Console.ReadLine()!);
    Console.Clear();
    bool even = Convert.ToInt32(input) % 2 == 0;

    if (even)
    {
        evennumbers += input;
        numberofinputs++;
        Console.WriteLine($"Even Numbers = {evennumbers} ");
        Console.WriteLine($"Odd Numbers = {oddnumbers} ");
        Console.WriteLine($"Number of Inputs = {numberofinputs} ");
    }

    else if (!even)
    {
        oddnumbers += input;
        numberofinputs++;
        Console.WriteLine($"Even Numbers = {evennumbers} ");
        Console.WriteLine($"Odd Numbers = {oddnumbers} ");
        Console.WriteLine($"Number of Inputs = {numberofinputs} ");

    }
}


//opgave 1.2
/*



bool while1 = false;
Console.WriteLine("Enter a number");
int input1 = Convert.ToInt32(Console.ReadLine()!);
int orginput1 = input1;
Console.Clear();

Console.WriteLine("Enter an another number");
int input2 = Convert.ToInt32(Console.ReadLine()!);
int orginput2 = input2;
while1 = true;
Console.Clear();




while (while1)
{
   
   


}

Console.WriteLine("end");
*/