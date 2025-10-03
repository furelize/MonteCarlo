// See https://aka.ms/new-console-template for more information

class Start
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the simulator!");
        Console.WriteLine("Please select the correct alternative");
        Console.WriteLine("1. Run simulator");
        Console.WriteLine("2. Credits");
        Console.WriteLine("3. Exit");
        string userchoicestr = Console.ReadLine();
        while (userchoicestr != "Exit" && userchoicestr != "Simulator" && userchoicestr != "Credits")
        {
            Console.WriteLine("Please give valid input");
            userchoicestr = Console.ReadLine();
        }
        switch (userchoicestr)
        {
            case "Simulator":
                //simulator();
                break;
            case "Credits":
                //Credits();
                break;
            default:
                Console.WriteLine("Thanks for using the program!");
                break;
        }
        }
}