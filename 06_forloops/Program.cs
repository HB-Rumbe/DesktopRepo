// https://www.w3resource.com/csharp-exercises/for-loop/index.php

// opgave 1
/*
Console.Clear();
for(int i = 1; i < 11; i++)
{
    Console.Write(i + " ");
}
*/

// opgave 2
/*
int sum = 0;
Console.Clear();
Console.WriteLine("The first 10 natural numbers: ");
for(int i = 1; i < 11; i++)
{
    Console.Write(i + " ");
    sum += i;
}
Console.WriteLine($"\nThe sum is: {sum}");
*/

// opgave 3
/*
Console.Clear();
Console.WriteLine("How many natural numbers would you like?");
int read = Convert.ToInt32(Console.ReadLine());

int sum = 0;
Console.Clear();
Console.WriteLine("The first 10 natural numbers: ");
for(int i = 1; i <= read; i++)
{
    Console.Write(i + " ");
    sum += i;
}
Console.WriteLine($"\nThe sum is: {sum}");
*/

// opgave 4
/*
Console.Clear();
double sum = 0;
int count = 1;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Write your ten numbers. ({count})");
    double read = Convert.ToDouble(Console.ReadLine());
    sum += read;
    count ++;
    Console.Clear();
}

double average = sum/10;

Console.WriteLine($"\nThe sum is: {sum}");
Console.WriteLine($"The average is: {average}");
*/

// opgave 5
/*
Console.Clear();
Console.WriteLine("How many cubed numbers would you like?");
int read = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Heres your list of cubed numbers");

for(int i = 1; i < read; i++)
{
    Console.WriteLine($"{i} cubed is {i*i*i}");
}
*/

// opgave 6
/*
Console.Clear();
Console.WriteLine("Which number would you like the multiplication table of?");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("How long would you like the table to be?");
int length = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for(int i = 1; i <= length; i++)
{
    Console.WriteLine($"{number} X {i} = {number*i}");
}
*/

// opgave 7
/*
Console.Clear();
Console.WriteLine("Which number would you like the multiplication table of?");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("How long would you like the table to be?");
int length = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for(int i = 1; i <= length; i++)
{
    Console.Write($"{number} X {i} = {number*i}, ");
}
*/
// opgave 8
/*
Console.Clear();
Console.WriteLine("How many odd numbers would you like?");
int length = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int oddnumbers = 1;
int sum = 0;

for (int i = 0; i < length; i++)
{
    Console.Write($"{oddnumbers} ");
    oddnumbers += 2;
    sum += oddnumbers;
}
Console.WriteLine($"\nThe sum of the first {length} odd numbers is {sum}");
*/
// opgave 9

/*
Console.Clear();
Console.WriteLine("How many rows would you like?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int astericks = 0;

for (int i = 0; i < rows; i++)
{
    astericks += 1;
    for (int j = 0; j < astericks; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

}
*/

//opgave 10
/*
Console.Clear();
Console.WriteLine("How many rows would you like?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int length = 0;

for (int i = 0; i < rows; i++)
{
    length += 1;
    for (int j = 1; j < length; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();

}
*/

//opgave 11
/*
Console.Clear();
Console.WriteLine("How many rows would you like?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int length = 0;

for (int i = 0; i < rows; i++)
{
    length += 1;
    for (int j = 1; j < length; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine();

}
*/

// opgave 12
/*
Console.Clear();
Console.WriteLine("How many rows would you like?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int length = 0;
int number = 1;

for (int i = 0; i < rows; i++)
{
    length += 1;
    for (int j = 1; j < length; j++)
    {

        Console.Write(number + " ");
        number++;
    }
    Console.WriteLine();

}
*/
// opgave 13 and 14
/*
Console.Clear();
Console.WriteLine("How many rows would you like?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int length = 0;
int number = 1;
int spaces = rows;

  
for (int i = 0; i <= rows; i++)
{
    
    for(int j = spaces; j>= 0; j--)
    {
    Console.Write(" ");
    }

    length += 1;    
    for (int j = 1; j < length; j++)
    {

        Console.Write(number + " ");
        //number++;
    }
    Console.WriteLine();
   spaces--;
}
*/
// opgave 15 (hits int limit around 15!)
/*
Console.Clear();
Console.WriteLine("How many rows would you like?");
int factorial = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int number = 1;

for (int i = factorial; i >= 1; i--)
{
    Console.Write($"{i} ");
    number *= i;

}
Console.WriteLine($"\nFactorial {factorial} = {number}");
*/
