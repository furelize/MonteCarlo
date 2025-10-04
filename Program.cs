// See https://aka.ms/new-console-template for more information
namespace Init
{
    class Start
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the simulator!");
            Console.WriteLine("Please select the correct alternative:");
            Console.WriteLine("Simulator");
            Console.WriteLine("Credits");
            Console.WriteLine("Exit");
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
                Console.WriteLine("Supervised by Robban, licensed under the gnu public license");
            }
            
            static void simulator()
            {   
                Console.WriteLine("Do you want to submit a file");
                string userchoicedata = Console.ReadLine();
                if (userchoicedata == "yes")
                {
                    Console.WriteLine("How many files do you want to input (only number supported)");
                    string numberdatafiles = Console.ReadLine();
                    int test; //only for testing 
                    while (!(int.TryParse(numberdatafiles, out test)))
                    {
                        Console.WriteLine("Give a real number");
                        numberdatafiles = Console.ReadLine();
                    }
                    string[] Datadir = new string[Convert.ToInt32(numberdatafiles)];
                    string userchoicedatavalid = "no";
                    for (int i = 0; i < Convert.ToInt32(numberdatafiles); i++)
                    {
                        userchoicedatavalid = "no";
                        while (userchoicedatavalid != "yes")
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the data file using using the standard linux filesystem as a reference");
                            Datadir[i] = Console.ReadLine();
                            while (!(File.Exists(Datadir[i])))
                            {
                                Console.WriteLine("Please link to a file that exists and that you have the correct permissions for");
                                Console.WriteLine("If you are sure that the file exists and that you can access it try inputing it in the / format");
                                Datadir[i] = Console.ReadLine();
                            }
                            Console.WriteLine($"Is the information correct: '{Datadir[i]}', yes or no?");
                            userchoicedatavalid = Console.ReadLine();
                            while (userchoicedata != "yes" && userchoicedata != "no")
                            {
                                Console.WriteLine("please give appropiate answear!");
                                userchoicedatavalid = Console.ReadLine();
                            }
                        }
                    }
                }
                Console.Clear();

            }
    }
}