using static System.Console;

int padding = 1;
string o = "o";
CursorVisible = false;
String newline = "\n";
bool newlin = false;

while(true)
{

    
    Clear();
    SetCursorPosition(0, 0);
    WriteLine("Money: " + money + "$");
    SetCursorPosition(x, y);
    Write("o");
    Thread.Sleep(speed);
    string read = Console.ReadLine()!;


    if (x == 80 && y == 5)
    {
        x = 0;
        y = 1;
        money++;

    }
    else if (x == 80)
    {
        x = 0;
        y++;

    }

    else if (read != "")
    {
        track = false;
        breakout = true;
        string help = "HELP SECTION";
        string t = "T = TRACK VIEW (Unpaused)";
        string h = "H = HELP SECTION (Paused)";
        string s = "S = SHOP VIEW (Paused)";
        Console.Clear();
        Console.SetCursorPosition((Console.WindowWidth - help.Length) / 4, Console.CursorTop);
        Console.WriteLine(help);
        Console.Write("\n");
        Console.SetCursorPosition((Console.WindowWidth - t.Length) / 4, Console.CursorTop);
        Console.WriteLine(t);
        Console.SetCursorPosition((Console.WindowWidth - h.Length) / 4, Console.CursorTop);
        Console.WriteLine(h);
        Console.SetCursorPosition((Console.WindowWidth - s.Length) / 4, Console.CursorTop);
        Console.WriteLine(s);
    }
    x++;
}


if(padding < 81)
{
 Thread.Sleep(50);
 Clear();
 padding++;
 Console.Write(o.PadLeft(padding));
  
}


}

