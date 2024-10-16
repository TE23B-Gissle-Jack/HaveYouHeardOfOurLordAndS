// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
List<string> chosenNames = [];
List<string> names = []; //= ["Mike", "Bob", "Trevor", "Bruce", "Jacob", "Jakob", "Karl", "Carl", "Joe", "Jeff", "Stanley", "John", "Dwayne"];
List<string> difNames = [];

int armyCount = 3;

while (true)
{
    difNames = ["Mike", "Bob", "Trevor", "Bruce", "Jacob", "Jakob", "Karl", "Carl", "Joe", "Jeff", "Stanley", "John", "Dwayne"];

    Console.WriteLine($"How many recuits do you want to recurit to your army? (Max {Convert.ToInt32(Math.Floor(difNames.Count/2f))})");
    string awns = Console.ReadLine();
    int.TryParse(awns, out armyCount);
    
    for (int amntSoldiers = 0; amntSoldiers < armyCount; amntSoldiers++)
    {
        ahhhh(5);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Write the number of the soldier you want to add to your army");
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i + 1 + " " + names[i]);
        }
        string choice = Console.ReadLine();
        int choiceNum = 0;
        int.TryParse(choice, out choiceNum);
        chosenNames.Add(names[choiceNum - 1]);
        difNames.Remove(names[choiceNum - 1]);
        Choices(chosenNames.Count, "are currently in your army", ConsoleColor.Cyan, chosenNames);
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your opponent choses to add");
    ahhhh(armyCount);
    Choices(armyCount, "", ConsoleColor.DarkYellow, names);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("to their army");

    Console.ReadLine();
    fight();
    chosenNames.Clear();
}

void ahhhh(int amt)
{
    names.Clear();

    List<string> ndifNames = new List<string>(difNames);
    for (int i = 0; i < amt; i++)
    {
        int name = Random.Shared.Next(ndifNames.Count - 1);
        //Console.WriteLine(name);
        names.Add(ndifNames[name]);
        ndifNames.RemoveAt(name);
    }
    // Console.WriteLine(names.Count);
}

void Choices(int times, string secondPart, ConsoleColor colour, List<string> theNames){
    string chocie = "";
    for(int i=0; i<times;i++)
    {
        if(i == times-2)
        {
            chocie = chocie +theNames[i]+ " And ";
        }
        else if(i == times-1)
        {
            chocie = chocie +theNames[i];
        }
        else
        {
            chocie = chocie +theNames[i]+ ", ";
        }
        
    }
    Console.ForegroundColor = colour;
    Console.WriteLine($"{chocie} {secondPart}");
}

void fight()
{   
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"The Fight begins with\n");
    Choices(armyCount, "on your side\n\n", ConsoleColor.Cyan, chosenNames);
    Choices(armyCount, "on your opponents side\n\n", ConsoleColor.Red, names);

    int yourSoldierCount = armyCount;
    int hisCount = armyCount;
    while (yourSoldierCount > 0 && hisCount > 0)
    {
        if (Random.Shared.Next(0, 2) == 1)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your soldier {chosenNames[0]} killed {names[0]}");
            names.RemoveAt(0);
            hisCount -= 1;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your opponents soldier {names[0]} killed {chosenNames[0]}");
            chosenNames.RemoveAt(0);
            yourSoldierCount -= 1;
        }

        Console.ReadLine();
    }
    if (hisCount == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"After a long and leangthy battle you manage to finish of your oppenent and his soldiers");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Your forces are overrun and you are slain by your oppenent");
    }
    Console.ReadLine();
}