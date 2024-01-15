
using static System.Console;
CursorVisible = false;
Console.Clear();
int x = 0;
int y = 1;
bool breakout = false;
bool track = true;
CursorVisible = false;
SetCursorPosition(x, y);
Write("o");
int multi = 1;
int money = multi * 1;
int speed = 1;

while (track)
{

    
    Clear();
    SetCursorPosition(0, 0);
    WriteLine("Money: " + money + "$");
    SetCursorPosition(x, y);
    Write("o");
    Thread.Sleep(speed);
    string read = Console.ReadLine();


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


while (breakout)
{
    switch (Console.ReadKey().KeyChar)
    {
        case 'h':
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
            break;

        case 's':
            Console.Clear();
            string welcome = "WELCOME TO THE SHOP";
            string booster = "BOOSTER (10% SPEED): 100$";
            Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 4, Console.CursorTop);
            WriteLine(welcome);
            Write("\n");
            Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 4, Console.CursorTop);
            WriteLine(booster);
            break;

        case 't':
            Console.Clear();
            breakout = false;
            track = true;
            break;
    }

}




