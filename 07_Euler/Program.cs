// https://projecteuler.net/archives

// ID 1
/*

 int sum = 0;

for(int i = 1; i < 1000; i++)
{
    int same = 0;
    if(i % 3 == 0)
    {
        same += i;
        Console.Write(i + " ");
        sum += i;
    }
    if(i % 5 == 0)
    {
        if(same == i)
        {}
        else
        {
        Console.Write(i + " ");
         sum += i;
        }
    }
}
Console.WriteLine($"\nThe sum is {sum}");
*/

// ID 2
/*
int f1 = 1;
int f2 = 1;
int f3 = 2;
int f4 = 3;
double goldenratio = 1.61803398875;
double fib;
double sum = f3;
Console.Write(f1 + "\n" + f2 + "\n" + f3 + "\n" + f4 + "\n");



for(double i = 3; i < 4000000;)
{
  fib = Math.Round(i*goldenratio); 
  i = fib;
  if(i%2 == 0)
  {
  sum += fib;
  Console.WriteLine(fib);
  }
  
 
  
}

Console.WriteLine($"This is the sum {sum}");
*/
