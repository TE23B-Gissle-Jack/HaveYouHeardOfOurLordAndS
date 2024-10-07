// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
List<string> chosenNames = [];
List<string> names = []; //= ["Mike", "Bob", "Trevor", "Bruce", "Jacob", "Jakob", "Karl", "Carl", "Joe", "Jeff", "Stanley", "John", "Dwayne"];
List<string> difNames = [];
while (true)
{
    difNames = ["Mike", "Bob", "Trevor", "Bruce", "Jacob", "Jakob", "Karl", "Carl", "Joe", "Jeff", "Stanley", "John", "Dwayne"];
    for (int amntSoldiers = 0; amntSoldiers < 3; amntSoldiers++)
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
        //Console.WriteLine("inan");
        int.TryParse(choice, out choiceNum);
        //Console.WriteLine("efter");
        chosenNames.Add(names[choiceNum - 1]);
        difNames.Remove(names[choiceNum - 1]);

        //  for(int i = 0; i < difNames.Count; i++){
        //     Console.WriteLine(difNames[i]);
        //  }
        // Console.ReadLine();

    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your opponent choses to add");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    ahhhh(3);

    Console.WriteLine($"{names[0]}, {names[1]} and {names[2]}");
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
void fight()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"The Fight begins with\n");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{chosenNames[0]}, {chosenNames[1]} and {chosenNames[2]} on your side\n");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{names[0]}, {names[1]} and {names[2]} on your opponents side\n\n");

    int yourSoldierCount = 3;
    int hisCount = 3;
    int i = 0;
    while (yourSoldierCount > 0 && hisCount > 0)
    {
        if (Random.Shared.Next(0, 2) == 1)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your soldier {chosenNames[i]} killed {names[i]}");
            hisCount -= 1;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your opponents soldier {names[i]} killed {chosenNames[i]}");
            yourSoldierCount -= 1;
        }

        Console.ReadLine();
        i++;
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