namespace TakingANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                char key = AskForSwitchChar("Choose a chapter to play through.\n1 - Plyers Guide Level3\n2 - Plyers Guide Level4\n3 - Plyers Guide Level6\n4 - Plyers Guide Level7\n5 - Plyers Guide Level8\n6 - Plyers Guide Level9\n7 - Plyers Guide Level10\n8 - Plyers Guide Level11\n9 - Plyers Guide Level12\nq - Exit");

                switch (key)
                {
                    case '1':
                        Console.Clear();
                        PlayersGuideLevel3();
                        break;

                    case '2':
                        Console.Clear();
                        PlayersGuideLevel4();
                        break;

                    case '3':
                        Console.Clear();
                        PlayersGuideLevel6();
                        break;

                    case '4':
                        Console.Clear();
                        PlayersGuideLevel7();
                        break;

                    case '5':
                        Console.Clear();
                        PlayersGuideLevel8();
                        break;

                    case '6':
                        Console.Clear();
                        PlayerGuideLevel9();
                        break;

                    case '7':
                        Console.Clear();
                        PlayerGuideLevel10();
                        break;

                    case '8':
                        Console.Clear();
                        PlayerGuideLevel11();
                        break;

                    case '9':
                        Console.Clear();
                        PlayerGuideLevel12();
                        break;

                    case 'q':
                        return;

                    default:
                        Console.Clear();
                        break;

                }
            }


            void PlayersGuideLevel3()
            {

                ConsolasAndTelim();
                HelloWorld();
                TheMakingsOfAProgrammer();
                WhatComesNext();

                void ConsolasAndTelim()
                {
                    Console.WriteLine("Bread is ready.");
                    string RB = AskForString("Who is the bread for?: ");
                    Console.WriteLine($"Noted: {RB} got bread");

                    CleanUp();
                }

                void HelloWorld()
                {
                    Console.WriteLine("Hello, World!");
                    CleanUp();
                }

                void TheMakingsOfAProgrammer()
                {
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"Hello, NPC {i}!");
                    }
                    CleanUp();
                }

                void WhatComesNext()
                {
                    Console.WriteLine("Is this good enough for you?");
                    CleanUp();
                }

            }

            void PlayersGuideLevel4()
            {

                TheThingNaamer3000();

                void TheThingNaamer3000()
                {

                    string a = AskForString("What kind of thing are we talking about?: ");
                    string b = AskForString("How would you describe it? Big? Azure? Tattered?: ");

                    string c = "of Doom";
                    string d = "3000";

                    Console.WriteLine($"The {b} {a} {c} {d}!");

                    CleanUp();

                }
            }

            void PlayersGuideLevel6()
            {
                TheVariableShop();
                TheVariableShopReturns();

                void TheVariableShop()
                {
                    byte Abyte = 0;
                    short Ashort = 0;
                    int Aint = 0;
                    long Along = 0L;
                    sbyte Asbyte = 0;
                    ushort Aushort = 0;
                    uint Auint = 0U;
                    ulong Aulong = 0U;
                    float Afloat = 0F;
                    double Adouble = 0;
                    decimal Adecimal = 0M;
                    char Achar = 'a';
                    string Astring = "a";
                    bool Abool = false;
                    Console.WriteLine($"byte {Abyte}\nshort {Ashort}\nint {Aint}\nlong {Along}\nsbyte {Asbyte}\nushort {Aushort}\nuint {Auint}\nulong {Aulong}\nfloat {Afloat}\ndouble {Adouble}\ndecimal {Adecimal}\nchar {Achar}\nstring {Astring}\nbool {Abool}");

                    CleanUp();
                }

                void TheVariableShopReturns()
                {

                    byte Abyte = 0;
                    short Ashort = 0;
                    int Aint = 0;
                    long Along = 0L;
                    sbyte Asbyte = 0;
                    ushort Aushort = 0;
                    uint Auint = 0U;
                    ulong Aulong = 0U;
                    float Afloat = 0F;
                    double Adouble = 0;
                    decimal Adecimal = 0M;
                    char Achar = 'a';
                    string Astring = "a";
                    bool Abool = false;

                    Abyte = 255;
                    Ashort = 32767;
                    Aint = 2147483647;
                    Along = 9223372036854775807L;
                    Asbyte = 127;
                    Aushort = 65535;
                    Auint = 4294967295U;
                    Aulong = 18446744073709551615U;
                    Afloat = 3.4F;
                    Adouble = 1.7;
                    Adecimal = 7.9M;
                    Achar = 'Ω';
                    Astring = "💻";
                    Abool = false;

                    Console.WriteLine($"byte {Abyte}\nshort {Ashort}\nint {Aint}\nlong {Along}\nsbyte {Asbyte}\nushort {Aushort}\nuint {Auint}\nulong {Aulong}\nfloat {Afloat}\ndouble {Adouble}\ndecimal {Adecimal}\nchar {Achar}\nstring {Astring}\nbool {Abool}");

                    CleanUp();
                }

            }

            void PlayersGuideLevel7()
            {

                TheDominionOfKings();
                TheFourSistersAndTheDuckbear();
                TheTriangleFarmer();

                void TheDominionOfKings()
                {
                    int estates = AskForInt("How many estates do you possess?: ");
                    int duchys = AskForInt("How many duchys do you possess?: ");
                    int provinces = AskForInt("How many provinces do you possess?: ");

                    Console.WriteLine($"{estates + duchys * 3 + provinces * 6}");

                    CleanUp();
                }

                void TheFourSistersAndTheDuckbear()
                {

                    int eggs = AskForInt("How many eggs are we talking about?: ");

                    int duckeggs = eggs % 4;
                    int eggsisters = (eggs - duckeggs) / 4;

                    Console.WriteLine($"The sisters get {eggsisters} egg/eggs while the duckbear gets {duckeggs} egg/eggs");

                    CleanUp();
                }

                void TheTriangleFarmer()
                {

                    Console.WriteLine((AskForDouble("What base should the triangel have?: ") * AskForDouble("What height do you want the triangel to be?: ")) / 2);

                    CleanUp();
                }
            }

            void PlayersGuideLevel8()
            {
                TheDefenseOfConsolas();

                void TheDefenseOfConsolas()
                {
                    int row = AskForInt("Target Row?: ");
                    int column = AskForInt("Target Column?: ");

                    Console.WriteLine("Deploy to");

                    int[] squads = { row, column - 1, row - 1, column, row, column + 1, row + 1, column };

                    int counter = 0;

                    List<ConsoleColor> colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();

                    for (int i = 0; i <= squads.Length / 2 - 1; i++)
                    {
                        counter++;
                        Console.ForegroundColor = colors[i + 1];
                        Console.WriteLine($"({squads[i - 1 + counter]}, {squads[i + counter]})");
                    }

                    Console.Beep();

                    CleanUp();

                }
            }

            void PlayerGuideLevel9()
            {

                RepairingTheClocktower();
                Watchtower();

                void RepairingTheClocktower()
                {
                    int input = AskForInt("Please input a number: ");

                    if (input % 2 == 0)
                    {
                        Console.WriteLine("Tick");
                    }
                    else
                    {
                        Console.WriteLine("Tock");
                    }

                    CleanUp();

                }

                void Watchtower()
                {

                    int x = AskForInt("What is the x-cord?: ");
                    int y = AskForInt("What is the y-cord?: ");

                    if (x < 0)
                    {
                        Y("west");
                    }
                    else if (x > 0)
                    {
                        Y("east");
                    }
                    else 
                    {
                        Y();
                    }
                    


                    void Y(string xStr = "")
                    {
                        string yStr = "";

                        if (y < 0)
                        {
                            yStr = "south";
                        }
                        else if (y > 0)
                        {
                            yStr = "north";
                        }

                        Console.WriteLine(xStr == "" && yStr == "" ? "The enemy is here!" : $"The enemy is to the {yStr}{xStr}!");

                    }

                    CleanUp();
                }

            }

            void PlayerGuideLevel10()
            {

                BuyingInventory();
                DiscountedInventory();

                void BuyingInventory()
                {

                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                        string userInput = AskForString("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n8 - Exit\nWhat number do you want to see the price of? ");

                        string Item;
                        int Price;

                        switch (userInput)
                        {
                            case "1":
                                Item = "Rope";
                                Price = 10;
                                break;

                            case "2":
                                Item = "Torches";
                                Price = 15;
                                break;

                            case "3":
                                Item = "Climbing Equipment";
                                Price = 25;
                                break;

                            case "4":
                                Item = "Clean Water";
                                Price = 1;
                                break;

                            case "5":
                                Item = "Machete";
                                Price = 20;
                                break;

                            case "6":
                                Item = "Canoe";
                                Price = 200;
                                break;

                            case "7":
                                Item = "Food Supplies";
                                Price = 1;
                                break;

                            case "8":
                                CleanUp();
                                return;

                            default:
                                ColorWriteLine("\nPlease input one of the numbers below.\n", ConsoleColor.Yellow);
                                continue;


                        }

                        Console.WriteLine($"{Item} cost {Price} gold.");

                        CleanUp();

                    }
                }

                void DiscountedInventory()
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                        string userInput = AskForString("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n8 - Exit\nWhat number do you want to see the price of?\n");
                        string name = AskForString("What is your name?: ");

                        double nameMod = 1;
                        string Item;
                        double Price;

                        if (name.ToLower() == "marcus")
                        {
                            nameMod = 0.5;
                        }

                        switch (userInput)
                        {
                            case "1":
                                Item = "Rope";
                                Price = 10 * nameMod;
                                break;

                            case "2":
                                Item = "Torches";
                                Price = 15 * nameMod;
                                break;

                            case "3":
                                Item = "Climbing Equipment";
                                Price = 25 * nameMod;
                                break;

                            case "4":
                                Item = "Clean Water";
                                Price = 1 * nameMod;
                                break;

                            case "5":
                                Item = "Machete";
                                Price = 20 * nameMod;
                                break;

                            case "6":
                                Item = "Canoe";
                                Price = 200 * nameMod;
                                break;

                            case "7":
                                Item = "Food Supplies";
                                Price = 1 * nameMod;
                                break;

                            case "8":
                                CleanUp();
                                return;

                            default:
                                ColorWriteLine("\nPlease input one of the numbers below.\n", ConsoleColor.Yellow);
                                continue;


                        }

                        Console.WriteLine($"{Item} cost {Price} gold.");

                        CleanUp();
                    }
                }
            }

            void PlayerGuideLevel11()
            {
                TheMagicCannon();
                ThePrototype();

                void TheMagicCannon()
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        if (i % 5 == 0 && i % 3 == 0)
                        {
                            ColorWriteLine($"{i}: Electric and Fire", ConsoleColor.Blue);
                        }
                        else if (i % 5 == 0)
                        {
                            ColorWriteLine($"{i}: Electric", ConsoleColor.Yellow);
                        }
                        else if (i % 3 == 0)
                        {
                            ColorWriteLine($"{i}: Fire", ConsoleColor.Red);
                        }
                        else
                        {
                            ColorWriteLine($"{i}: Normal", ConsoleColor.White);
                        }
                    }

                    CleanUp();

                }
                void ThePrototype()
                {

                    int Pilot = AskForNumberInRange("The pilot, enters a number between 0 and 100: ", 0, 100);

                    Console.Clear();

                    Console.WriteLine("Hunter, guess the number.");

                    while (true)
                    {

                        int hunter = AskForInt("What is your next guess?: ");

                        if (hunter < Pilot)
                        {
                            ColorWriteLine($"{hunter} is too low.", ConsoleColor.Yellow);
                        }
                        else if (hunter > Pilot)
                        {
                            ColorWriteLine($"{hunter} is too high.", ConsoleColor.Red);
                        }
                        else
                        {
                            ColorWriteLine("You guessed the number!", ConsoleColor.Green);
                            break;
                        }
                    }

                    CleanUp();

                }
            }

            void PlayerGuideLevel12()
            {

                TheLawsOfFreach();
                TheReplicatorOfDTo();

                void TheLawsOfFreach()
                {
                    int[] NumArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

                    double Avg = 0;
                    int Min = 0;

                    foreach (int i in NumArray)
                    {
                        Avg += i;

                        if (Min > i)
                        {
                            Min = i;
                        }
                    }

                    Console.WriteLine($"The average of the array is {Avg / NumArray.Length} and the smallest number in the array is {Min}.");

                    CleanUp();

                }

                void TheReplicatorOfDTo()
                {
                    int[] OrgArray = new int[5];
                    int[] CopyArray = new int[5];

                    for (int x = 0; x < OrgArray.Length; x++)
                    {
                        OrgArray[x] = AskForInt("Please enter a number: ");
                    }

                    for (int z = 0; z < CopyArray.Length; z++)
                    {
                        CopyArray[z] = OrgArray[z];
                    }

                    for (int y = 0; y < OrgArray.Length; y++)
                    {
                        Console.WriteLine($"Original array: {OrgArray[y]} Copied array: {CopyArray[y]}");
                    }

                    CleanUp();
                }
            }

        }

        public static int AskForInt(string text, bool exceptionInfo = false)
        {
            int userInput = 0;

            while (true)
            {

                Console.Write(text);

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                catch (Exception ex)
                {

                    if (exceptionInfo)
                    {
                        Console.WriteLine(ex);
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid number!");
                    }

                }

            }

            return userInput;
        }

        public static double AskForDouble(string text, bool exceptionInfo = false)
        {

            double userInput = 0;

            while (true)
            {

                Console.Write(text);

                try
                {
                    userInput = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {

                    if (exceptionInfo)
                    {
                        Console.WriteLine(ex);
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid floating-point value or an integer!");
                    }

                }
            }

            return userInput;
        }

        public static string AskForString(string text, bool exceptionInfo = false)
        {

            string userInput = "";

            while (true)
            {
                Console.Write(text);

                try
                {
                    userInput = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {

                    if (exceptionInfo)
                    {
                        Console.WriteLine(ex);
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid string");
                    }

                }
            }

            return userInput;
        }

        public static void ColorWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        public static void ColorWrite(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
        }

        public static int AskForNumberInRange(string text, int min, int max)
        {

            while (true)
            {

                int userInput = AskForInt(text);

                if (userInput >= min && userInput <= max)
                {
                    return userInput;
                }
            }
        }

        public static char AskForSwitchChar(string text)
        {
            Console.Write(text);
            char key = Console.ReadKey(true).KeyChar;

            return key;
        }

        public static void CleanUp()
        {
            ColorWriteLine("Press any button to continue.",ConsoleColor.Yellow);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.ReadKey();
            Console.Clear();
        }

    }
}