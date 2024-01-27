
Console.Clear();
Console.WriteLine("Welcome to Russian Roulette!");
Thread.Sleep(2000);
Console.Clear();
Console.CursorVisible = false;
Random rnd = new Random();
List<int> roulette = new List<int>
{
1,1,1,1,1,1,
};

int random = rnd.Next(0, 5);
roulette[random] = 0;
/*
for (int i = 0; i < 6; i++)
{
 Console.WriteLine(roulette[i]);
}
*/
int player = 1;
for (int i = 0; i < 6; i++)
{
 if (random % 2 == 0)
 {
  Console.WriteLine($"Player {player}´s turn. Press any key to shoot. (Turn {i + 1})");
  Console.ReadKey();
  Console.Clear();
 }
 else
 {
  Console.WriteLine($"Player {player}`s turn. Press any key to shoot. (Turn {i + 1})");
  Console.ReadKey();
  Console.Clear();
 }
 if (roulette[i] == 1)
 {
  Console.Write("\nBANG!");
  Thread.Sleep(500);
  Console.Write(".");
  Thread.Sleep(500);
  Console.Write(".");
  Thread.Sleep(500);
  Console.Write(".");
  Thread.Sleep(500);
  Console.Write(" You Survived. The shot was a blank.\n");
  Thread.Sleep(2000);
  Console.Clear();
  if (player == 1)
  {
   player = 2;
  }
  else if (player == 2)
  {
   player = 1;
  }


 }
 else if (roulette[i] == 0)
 {
  Console.Write("\nBANG!");
  Thread.Sleep(500);
  Console.Write(".");
  Thread.Sleep(500);
  Console.Write(".");
  Thread.Sleep(500);
  Console.Write(".");
  Thread.Sleep(500);
  Console.Write(" You Died");
  Console.ReadKey();
  break;
 }

}