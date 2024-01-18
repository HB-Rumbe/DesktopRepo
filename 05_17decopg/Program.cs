
// https://www.w3resource.com/csharp-exercises/array/index.php

// opgave 1
/*
while (true)
{
    Console.WriteLine("How long should the array be?");
    int arraylength = Convert.ToInt32(Console.ReadLine());
    Console.Clear();


    int i = 0;
    int[] inputs = new int[arraylength];

    for ( ; i < inputs.Length; i++)
    {
        Console.WriteLine($"Please write a number. ({i + 1})");
        int read = Convert.ToInt32(Console.ReadLine()!);
        inputs[i] = read;
        Console.Clear();
    }

    Console.Write("\nHere are your inputs: ");

    for (int n = 0; n < inputs.Length; n++)
    {
        Console.Write(inputs[n] + " ");
    }
    break;
}
*/

// opgave 2
/*
while(true)
{
Console.Clear();
int i = 0;
int[] inputs = new int[3];

for( ; i < 3; i++)
{
Console.WriteLine($"Please write a number. ({i+1})");
int read = Convert.ToInt32(Console.ReadLine()!);
inputs[i] = read; 
Console.Clear();
}

Console.Write("\nHere are your inputs in reverse order: ");

for(int n = 2; n>-1; n--)
{
    Console.Write(inputs[n]+ " ");
}
break;
}
*/
// opgave 3
/*
while (true)
{
    
    Console.WriteLine("How long should the array be?");
    int arraylength = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    
    int sum = 0;

    int i = 0;
    int[] inputs = new int[arraylength];

    for ( ; i < inputs.Length; i++)
    {
        Console.WriteLine($"Please write a number. ({i + 1})");
        int read = Convert.ToInt32(Console.ReadLine()!);
        inputs[i] = read;
        Console.Clear();
    }

    for (int n = 0; n < inputs.Length; n++)
    {
        sum += inputs[n];
    }

    Console.Write($"\nHere is the sum of your inputs: {sum}");
    break;
}
*/
// opgave 4
/*
while (true)
{
    Console.WriteLine("How long should the array be?");
    int arraylength = Convert.ToInt32(Console.ReadLine());
    Console.Clear();



    Console.Clear();
    int i = 0;
    int[] inputs = new int[arraylength];
    int[] inputcopy = new int[arraylength];

    for ( ; i < inputs.Length; i++)
    {
        Console.WriteLine($"Please write a number. ({i + 1})");
        int read = Convert.ToInt32(Console.ReadLine()!);
        inputs[i] = read;
        Console.Clear();
    }

    for (int n = 0; n < inputs.Length; n++)
    {
        inputcopy[n] = inputs[n];
    }


    Console.Write("\nHere are your inputs: ");

    for (int n = 0; n < inputs.Length; n++)
    {
        Console.Write(inputs[n] + " ");
    }

    Console.Write("\nHere are the copied inputs: ");
    for (int n = 0; n < inputcopy.Length; n++)
    {
        Console.Write(inputcopy[n] + " ");
    }


    break;
}
*/
//opgave 5
/*

while (true)
{
    Console.WriteLine("How long should the array be?");
    int arraylength = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    int numberofdupicates = 0;

    int i = 0;
    int[] inputs = new int[arraylength];


    for ( ; i < inputs.Length; i++)
    {
        Console.WriteLine($"Please write a number. ({i + 1})");
        int read = Convert.ToInt32(Console.ReadLine()!);
        for (int b = 0; b < inputs.Length; b++)
        {
            if (read == inputs[b])
            {
                numberofdupicates++;
                b = inputs.Length + 1;
            }
        }

        inputs[i] = read;
        Console.Clear();

    }

    Console.Write("\nHere are your inputs: ");

    for (int n = 0; n < inputs.Length; n++)
    {
        Console.Write(inputs[n] + " ");
    }
    Console.WriteLine($"Number of duplicates: {numberofdupicates}");
    break;
}
*/
// opgave 6
/*
while (true)
{
    Console.Clear();
    Console.WriteLine("How long should the array be?");
    int arraylength = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    int count = 0;

    int[] inputs = new int[arraylength];
    int[] uniques = new int[arraylength];

    for (int i = 0; i < inputs.Length; i++)
    {
        Console.WriteLine($"Please write a number. ({i + 1})");
        int read = Convert.ToInt32(Console.ReadLine()!);
        inputs[i] = read;
        Console.Clear();

    }
    Console.Write($"\nArray length: {arraylength}");
    Console.Write("\nYour inputs: ");
    for (int i = 0; i < inputs.Length; i++)
    {
        Console.Write(inputs[i] + " ");
    } 

    Console.Write("\nUnique numbers: ");

    for (int i = 0; i < inputs.Length; i++)
    {
        count = 0;

        for (int j = i - 1; j > -1; j--)
        {
            if (inputs[j] == inputs[i])
            {
                count++;
            }

        }

        for (int j = i + 1; j < inputs.Length; j++)
        {
            if (inputs[j] == inputs[i])
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.Write(inputs[i] + " ");
        }
    }
    break;
}
*/
//opgave 7 unfinished
/*
Console.Clear();
Console.WriteLine("How long should the first array be?");
int arraylength = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Clear();
Console.WriteLine("How long should the second array be?");
int arraylength2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[] array1 = new int[arraylength];
int[] array2 = new int[arraylength2];

int[] arrayordered = new int[arraylength + arraylength2];

for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine($"Please write a number for the first array. ({i + 1})");
    int read = Convert.ToInt32(Console.ReadLine()!);
    array1[i] = read;
    Console.Clear();
}

for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine($"Please write a number for the second array. ({i + 1})");
    int read = Convert.ToInt32(Console.ReadLine()!);
    array2[i] = read;
    Console.Clear();
}










Console.Write("\narray1: ");
for (int n = 0; n < array1.Length; n++)
{
    Console.Write(array1[n] + " ");
}
Console.Write("\narray2: ");
for (int n = 0; n < array2.Length; n++)
{
    Console.Write(array2[n] + " ");
}

Console.Write("\narrayordered:");
for (int n = 0; n < arrayordered.Length; n++)
{
    Console.Write(arrayordered[n] + " ");
}
*/
// opgave 8 unfinished
/*
while (true)
{
    Console.Clear();
    Console.WriteLine("How long should the array be?");
    int arraylength = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    int count = 0;

    int[] inputs = new int[arraylength];
    int[] amount = new int[arraylength];

    for (int i = 0; i < inputs.Length; i++)
    {
        Console.WriteLine($"Please write a number. ({i + 1})");
        int read = Convert.ToInt32(Console.ReadLine()!);
        inputs[i] = read;
        Console.Clear();
    }

    for (int i = 0; i < inputs.Length; i++)
    {
        count = 0;
        for (int j = 0; j < inputs.Length; j++)
        {

            if (inputs[i] == inputs[j])
            {
                count++;
                

            }



        }
        amount[i] = count;
    }

    for (int i = 0; i < inputs.Length; i++)
    {
        if (amount[i] != 0)
        {
            Console.WriteLine($"{inputs[i]} occurs {amount[i]}");


        }



    }



    Console.Write("\nHere are your inputs: ");

    for (int n = 0; n < inputs.Length; n++)
    {
        Console.Write(inputs[n] + " ");
    }
    break;
}
*/












