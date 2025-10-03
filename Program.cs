// See https://aka.ms/new-console-template for more information
namespace Init
{
    class Start
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the simulator!");
            Console.WriteLine("Please select the correct alternative");
            Console.WriteLine("1. Simulator");
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
                    simulator();
                    break;
                case "Credits":
                    Credits();
                    break;
                default:
                    Console.WriteLine("Thanks for using the program!");
                    break;
            }
            }
            static void Credits()
            {
                Console.Clear();
                Console.WriteLine("Written by Sebastian Warnholtz and Samuel Sylvan");
            }
            
            static void simulator()
            {
                Console.Clear();
                Console.WriteLine("Enter the data file using ~ (standard linux filesystem is the only accepted format)");
                string Datadir = Console.ReadLine();
                while (File.Exists(Datadir))
                {
                    Console.WriteLine("Please link to a file that exists and that you have the correct permissions for");
                    Datadir = Console.ReadLine();
                }
            }
    }
}