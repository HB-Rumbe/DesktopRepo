
string character = "o";
int padding = 20;
int money = 0;


bool generator = false;




while (true)
{



    Char key = Console.ReadKey().KeyChar;

    if (key == 'a' && !padding.Equals(19))
    {
        padding--;
        Console.Clear();
        Console.WriteLine(character.PadLeft(padding));
        Console.WriteLine(money);
    }

    else if (key == 'd' && !padding.Equals(81))
    {
        padding++;
        Console.Clear();
        Console.WriteLine(character.PadLeft(padding));
        Console.WriteLine(money);
    }
    else if (key == ' ')
    {
        money++;
        Console.Clear();
        Console.WriteLine(character.PadLeft(padding));
        Console.WriteLine(money);
    }

    else if (key == 'q')
    {
        break;
    }



    if (money >= 100 && generator == false && padding == 80)
    {
    money -= 100;
    generator = true;
    }
    
           

    

    if(generator)
    {
        money++;
        await Task.Delay(1000);
    }

}






