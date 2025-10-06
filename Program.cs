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
                string numberdatafiles = "0";
                if (userchoicedata == "yes")
                {
                    while ((Convert.ToInt32(numberdatafiles) > 100) || (Convert.ToInt32(numberdatafiles) == 0))
                    {
                        Console.WriteLine("How many files do you want to input (only number supported)");
                        numberdatafiles = Console.ReadLine();
                        int test; //only for testing
                        while (!(int.TryParse(numberdatafiles, out test)))
                        {
                            Console.WriteLine("Give a real number");
                            numberdatafiles = Console.ReadLine();
                        }
                        if (Convert.ToInt32(numberdatafiles) > 100)
                        {
                            Console.WriteLine("please enter a real number under 100");
                        }
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
                rotatingrectangle(3);
                Console.Clear();
                for (int i = 0; i < Convert.ToInt32(numberdatafiles)+4; i++)
                {
                    loadingbar(10,i);
                }
                Console.WriteLine("Data Successfully initialized!");


            }
            static void loadingbar(int time, int positiony)
            {
                for (int i = 1; i < 51; i++)
                {
                    Console.SetCursorPosition(0,positiony);
                    Console.WriteLine("[");
                    
                    if (i != 50)
                    {
                        Console.SetCursorPosition(i,positiony);
                        Console.WriteLine("#");
                    } else 
                    {
                        Console.SetCursorPosition(i,positiony);
                        Console.WriteLine("]");
                        Console.SetCursorPosition(i+2,positiony);
                        Console.WriteLine("100%");
                    }
                    Thread.Sleep(time);
                    
                }
            }
            static void rotatingrectangle(int time)
            {
                for (int d = 0; d < 360*time; d++)
                {   
                    Console.Clear();
                    int k = 1;
                    int x = Math.Abs(Convert.ToInt32(Math.Cos(d*Math.PI/180)*5));
                    for (int a = 0; a < 2; a++)
                    {
                        for (int i = 0; i < 6; i++)
                        {              
                            Console.SetCursorPosition(k*x+5,i);
                            Console.WriteLine("#");
                        }
                        for (int j = x; j > -1; j-- )
                        {
                            Console.SetCursorPosition(k*j+5,5);
                            Console.WriteLine("#");
                            Console.SetCursorPosition(k*j+5,0);
                            Console.WriteLine("#");
                        }
                        k = -1;
                    }
                    Console.SetCursorPosition(12,0);
                    Console.WriteLine("Calculating Data!");
                    Thread.Sleep(10);
                }
            }
            static void MonteCarlo(int numberofdatafiles, string[] datadirectory)
            {
            }
    }
}
