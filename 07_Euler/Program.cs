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
// ID 3

Console.WriteLine($"This is the sum {sum}");
/*

Console.Clear();
Console.WriteLine("Which number would you like to check?");
long number = Convert.ToInt64(Console.ReadLine());
Console.Clear();

for (int i = 2; 1 < number; i++)
{
    if (number % i == 0)
    {
        int count = 0;
        while (number % i == 0)
        {
            number /= i;
            count++;
             Console.WriteLine($"{i} is a prime factor");
        }
    }
}
*/

//ID 4
/*
for (int i = 999; i > 900; i--)
{
    for (int j = 999; j > 900; j--)
    {
        int reverse = 0;
        int num = i * j;
       
        while (num > 0)
        {
            int remainder = num % 10;
            reverse = (reverse * 10) + remainder;
            num = num / 10;
        }
        num  = i*j;
        if (reverse == num)
        {
            Console.WriteLine($"{num} = {i} X {j}");
        }
    }
}
*/

// ID 5
/*

for(int i = 20; i>0; i++)
{
    bool evenly = true;
    for(int j = 1; j<21; j++)
    {
        if(i % j != 0)
        {
            evenly = false;
        }

    }
    if(evenly)
    {
    Console.WriteLine(i);
    break;
    }
}
*/

//ID 6
/*
double sq = 0;
double naturalsum = 0;
double naturalsumsq = 0;
double answer = 0;

for(int i = 1; i<=100; i++)
{
sq += Math.Pow(i,2); 
naturalsum+= i;
}
naturalsumsq = Math.Pow(naturalsum,2);
answer = naturalsumsq-sq;
Console.WriteLine(answer);
*/

//ID 7
/*

int count = 0;
int term = 0;
for (int i = 2; i < 40000000; i++)
{
    for(int j = 2; j<i; j++)
    {
        if(i % j == 0)
        {
            count++;
        }
        if(count > 1)
        {
          break;  
        }
        
    }

    if(count < 1)
    {
        Console.WriteLine(i);
        term += 1;

    }
    count = 0;
    if(term == 10001)
    {
        Console.WriteLine($"The 10001 term is {i}");
       break; 
    }

}
*/

// ID 8
/*
String digits = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
long sum = 0;
long highestnumber = 0;
for (int i = 0; i < 987; i++)
{
    sum = 1;
    string substring1 = digits.Substring(i, 13);
    for (int j = 0; j < 13; j++)
    {
    long substring2 = Convert.ToInt64(substring1.Substring(j,1));
    sum *= substring2;
    }

    if(sum != 0)
    {
        if (sum > highestnumber)
        {
            highestnumber = sum;
        }
    }
}
Console.WriteLine(highestnumber);
*/

// ID 9
/*
double c = 0;

for (double a = 1; true; a++)
{
    for (double b = a + 1; b < 1000; b++)
    {
        c = Math.Pow(a, 2) + Math.Pow(b, 2);

        if (a < b && b < Math.Round(Math.Sqrt(c)) && Math.Sqrt(c) % 1 == 0 && Math.Sqrt(c) + a + b == 1000)
        {
            Console.WriteLine($"{a} + {b} + {Math.Sqrt(c)} = {a + b + Math.Sqrt(c)}");
            Console.WriteLine(a * b * Math.Sqrt(c));
            return;
        }
    }
}
*/

// ID 10
/*
int count = 0;
long sum = 0;

for (int i = 2000000; i > 1; i--)
{
    for (int j = 2; j < Math.Round(Math.Sqrt(i)) + 1; j++)
    {   
        if (i % j == 0)
        {
            count++;
        }
        if (count > 1)
        {
            break;
        }
    }
    if (count < 1)
    {
        sum += i;
    }
    count = 0;
}
Console.WriteLine(sum);
*/

// ID 11
