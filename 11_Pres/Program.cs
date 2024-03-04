
// for loop

// fibonacci tal med Big Integer
using System.Numerics;
Console.Clear();
Console.WriteLine("Which Iteration value do you want to see?");
int iteration = Convert.ToInt32(Console.ReadLine());
int iterationcount = 3;
BigInteger a = 1;
BigInteger b = 1;
BigInteger sum = 0;
Console.Clear();
Console.WriteLine("0");
Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 0; i < iteration - 3; i++)
{
 sum = a + b;
 a = b;
 b = sum;
 Console.WriteLine(sum);
 iterationcount++;
 // da
}
Console.WriteLine($"Iteration {iterationcount}'s value is {sum}");


// fibonacci tal uden Big Integer

// foreach


// while loop


// do while loop

