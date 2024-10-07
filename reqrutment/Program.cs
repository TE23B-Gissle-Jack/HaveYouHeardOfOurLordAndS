// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
List<string> names = []; //= ["Mike", "Bob", "Trevor", "Bruce", "Jacob", "Jakob", "Karl", "Carl", "Joe", "Jeff", "Stanley", "John", "Dwayne"];
List<string> difNames = [];
while (true)
{
    difNames = ["Mike", "Bob", "Trevor", "Bruce", "Jacob", "Jakob", "Karl", "Carl", "Joe", "Jeff", "Stanley", "John", "Dwayne"];
    for (int amntSoldiers = 0;amntSoldiers < 3; amntSoldiers++)
    {
        ahhhh();
        Console.WriteLine("Write the name of the soldier you want to add to your army");
         for (int i = 0; i < 5; i++){
            Console.WriteLine(i+1 + " " + names[i]);
         }
         string choice = Console.ReadLine();
         int choiceNum = 0;
          //Console.WriteLine("inan");
         int.TryParse(choice, out choiceNum);
         //Console.WriteLine("efter");
         difNames.Remove(names[choiceNum-1]);

         for(int i = 0; i < difNames.Count; i++){
            Console.WriteLine(difNames[i]);
         }
         Console.ReadLine();
    }
    Console.ReadLine();
}

void ahhhh()
{
    if(names.Count > 0){
    for(int i = 0; i >5; i++){
        names.RemoveAt(i);
    }
    }
    List<string> ndifNames = new List<string>(difNames);
    for (int i = 0; i < 5; i++)
    {
        int name = Random.Shared.Next(difNames.Count-1);
        Console.WriteLine(name);
        names.Add(difNames[name]);
        ndifNames.Remove(difNames[name]);
    }
    Console.WriteLine(names.Count);
}