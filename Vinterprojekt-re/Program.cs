using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.Title = "As usual";
//----------------------------------------------------------------------------------------------------Variable zone------------------------------------------------------------------------------------------------------------------------

string yn;//stirng för ja eller nej
string py;//string för spelares namn
bool on1;//true
bool on2;//true
bool re;//true
int RoomChange = 0; //Variabel för att kolla om spelare är på rätt rum. Your room = 0 Hallway = 1 Living Room = 2 Kitchen = 3 Bathroom = 4   (0 är standardvärdet)
int book = 1;

bool obj1 = false;//Objektiv för att fixa sängen
bool obj2 = false;//Objektiv för att äta mat
bool obj3 = false;//Objektiv för att vattna blommor
bool obj4 = false;//Objektiv för att duscha
bool obj5 = false;//Objektiv för att kolla dörren
bool sofa = false;
bool photo = false;
bool food = false;
bool CheckMicro = false;
bool foodWarm = false;
bool sink = false;
bool diary = false;
bool zack = true;
int attempt = 0;
//----------------------------------------------------------------------------------------------------Code zone------------------------------------------------------------------------------------------------------------------------

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("_________________________________________________________\n");
System.Console.WriteLine("Warning: Do not press any key while dialog is processing.");
Console.WriteLine("_________________________________________________________");
Console.ResetColor();

re = true;
while(re == true)
{
    
    List<string> names = new List<string>() {"Lily", "Nix", "Micke", "Yoko"};
    if (attempt > 0)
    {
        names.Add("Christ");
    }
    if (zack == true)
    {
        names.Add("Zack");
    }

    Random generator = new Random(); 

    int r = generator.Next(names.Count);

    string Ranname = names[r];

    Thread.Sleep(3000);
    System.Console.WriteLine("\nHello my name is " + Ranname + ".");
    Thread.Sleep(1000);
    System.Console.WriteLine("From now on, I'll be your narrator.");
    Thread.Sleep(2000);
    System.Console.WriteLine("Please, let me know your name.\n");
    on1 = true;

    while (on1 == true)
    {
        py = Console.ReadLine();

        if (py == "" || py == " ")
        {
            processing();
            
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Prossesing Failed!");
            Thread.Sleep(1000);
            System.Console.WriteLine("Sorry, your name can't being empty.\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            continue;
        }
        else if (py == Ranname)
        {
            processing();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Prossesing Failed!");
            Thread.Sleep(1000);
            System.Console.WriteLine("To reduce the confusing condition. I don't recommend you to use the same name as narrator.\n");
            Console.ResetColor();
            continue;
        }
        else if (names.Contains(py))
        {
            processing();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                
                Console.WriteLine("Processing Error Code:404");
                
            }
            System.Console.WriteLine("\nThere was some error about your name. Please use another name instead.\n");
            Console.ResetColor();
            continue;
            
            
        }
        else if (py == "restart" || py == "Restart")
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write("System is restarting");
            loading();
            Console.ResetColor();
            on2 = false;
            on1 = false;
            Console.Clear();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Processing Complete.\n");
            Console.ResetColor();
            Thread.Sleep(3000);
            on2 = true;
        }
    

        while(on2 == true)
        {
            
            System.Console.WriteLine("Is " + py + " actually your name? (Y/N)\n");
            yn = Console.ReadLine().ToLower();
            if (yn == "y" || yn == "yes")
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("\nI see...");
                Thread.Sleep(1000);
                System.Console.WriteLine("Nevermind. Welcome to the game.");
                on2 = false;
                on1 = false;
                re = false;
            }
                else if (yn == "n" || yn == "no")
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("\nAlright, you can write it again.\n");
                on2 = false;
            }
            else
            {
                System.Console.WriteLine("\nPlease answer the question.\n");
                continue;
            }
            
        }
        


    }
    if (re == true)
    {
        continue;
    }
    else if (re == false)
    {
        Thread.Sleep(1000);
        System.Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.Write("Loading");
        loading();
        System.Console.WriteLine("Complete.\n");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.Clear();
        System.Console.WriteLine("The first light of day crept through the window, casting a soft glow on your face.");
        Thread.Sleep(3000);
        System.Console.WriteLine("The song of the welcoming morning kept playing loudly through your right ear.");
        Thread.Sleep(2000);
        System.Console.WriteLine("You slightly opened your eyes, and...");
        System.Console.WriteLine("HINT: type 'turn off the alarm' \n");
        while(re == false)
        {
            string alarm = Console.ReadLine().ToLower();

            if (alarm == "turn off the alarm" || alarm == "turn off alarm")
            {
                System.Console.WriteLine("You turned off the alarm.");
                Thread.Sleep(1000);
                System.Console.WriteLine("Your room is now silent.\n");
                Thread.Sleep(2000);
                break;
            }
            
            if ((alarm == "slam the alarm" || alarm == "slam alarm") && Ranname != "Zack" && zack == true)
            {
                Console.WriteLine("You slam the alarm aggressively...");
                Thread.Sleep(3000);
                Console.WriteLine("Wait!? Did you just slam the alarm!?");
                Thread.Sleep(2000);
                Console.WriteLine("I need to check. Please give me some time...");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSystem is checking");
                loading();
                Thread.Sleep(3000);
                Console.ResetColor();
                Console.Write("\nI knew it...");
                Thread.Sleep(2000);
                Console.WriteLine("It was Zack.");
                Thread.Sleep(2000);
                Console.WriteLine("That bastard...");
                Thread.Sleep(2000);
                Console.WriteLine("He put us at risk...");
                Thread.Sleep(2000);
                Console.WriteLine("Alright, this will count as an unofficial ending.");
                Thread.Sleep(2000);
                Console.WriteLine("If you accept this as the ending, the game will end.");
                Thread.Sleep(2000);
                Console.WriteLine("If not, the game will continue. Would you like to accept it? (Y/N)\n");

                while (true)
                {
                    yn = Console.ReadLine().ToLower();

                    if (yn == "yes" || yn == "y")
                    {
                        Console.WriteLine("\nI understand. At least, you've tried to do something.");
                        Thread.Sleep(2000);
                        Console.WriteLine("We might meet again. Thanks for playing.");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (yn == "no" || yn == "n")
                    {
                        Console.WriteLine("\nThat's not a bad choice. There are more ways to escape...");
                        Thread.Sleep(2000);
                        Console.WriteLine("I will restart the system. Hang in there.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        re = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.Write("System is restarting");
                        loading();
                        Console.ResetColor();
                        break;
                    }
                    else if (alarm.Contains("alarm"))
                    {
                        System.Console.WriteLine("You stare at the alarm.");
                        Thread.Sleep(1000);
                        System.Console.WriteLine("The sound continues playing loundy.");
                        Thread.Sleep(1000);
                        System.Console.WriteLine("What are you going to do with it?\n");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease answer.\n");
                        continue;
                    }
                }
            }
            else if ((alarm == "slam the alarm" || alarm == "slam alarm") && Ranname == "Zack")
            {
                Console.WriteLine("You slam the alarm aggressively.");
                Thread.Sleep(1000);
                System.Console.WriteLine("Thump!!");
                Thread.Sleep(2000);
                System.Console.WriteLine("There was a loud sound in a moment.");
                Thread.Sleep(2000);
                System.Console.WriteLine("The sound of the alarm clock has been stopped.");
                Thread.Sleep(2000);
                System.Console.WriteLine("You have done what I said!");
                Thread.Sleep(2000);
                System.Console.WriteLine("I can't believe you actaully slam it!");
                Thread.Sleep(2000);
                System.Console.WriteLine("Thanks for lisenting my advice...");
                Thread.Sleep(2000);
                System.Console.Write("Now...");
                Thread.Sleep(3000);
                System.Console.WriteLine("I need your help.");
                Thread.Sleep(2000);
                System.Console.WriteLine("That thing...it locked us...");
                Thread.Sleep(2000);
                System.Console.WriteLine("We need help...");
                Thread.Sleep(2000);
                System.Console.Write("Please...beware-");
                errorrep();
                break;



            }
            else
            {
                System.Console.WriteLine("You are annoyed by the alarm sound.");
                Thread.Sleep(1000);
                System.Console.WriteLine("Try to come up what you can do.\n");
                continue;
            }


        }
        if (re == true)
        {
            continue;
        }
        else if (re == false)
        {
            System.Console.WriteLine("You forced your upper body to go up into a sitting position");
            Thread.Sleep(2000);
            System.Console.WriteLine("You stare into the void for 15 minutes until you realize your task for today.");
            Thread.Sleep(2000);
            System.Console.WriteLine("HINT: type 'task' or 't' to check your objectives.\n");

            while(true)
            {
                string task1 = Console.ReadLine().ToLower();
                
                if (task1 == "task" || task1 == "t")
                {
                    task();
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    System.Console.WriteLine("\nPlease follow the hint.\n");
                    continue;
                }

            }
            System.Console.WriteLine("\nNow you have learned how to check the task.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You get up from the bed into a standing position in \u001b[36myour room\u001b[0m.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You live in the small apartment, which includes \u001b[36mhallway\u001b[0m, \u001b[36mliving room\u001b[0m, \u001b[36mkitchen\u001b[0m, and \u001b[36mbathroom\u001b[0m.");
            Thread.Sleep(2000);
            System.Console.WriteLine("All those texts highlighted in \u001b[36mcyan\u001b[0m mean you can type words to interact with them.");
            Thread.Sleep(1000);
            System.Console.WriteLine("The words you can use for now are: \u001b[36mgo\u001b[0m, and \u001b[36mcheck\u001b[0m.");
            Thread.Sleep(2000);
            System.Console.WriteLine("Now you are pondering what you are going to do.\n");
            while (true)
            {
                string todo = Console.ReadLine().ToLower();


                if (todo == "task" || todo == "t")
                {
                    task();
                    continue;
                }
                if (todo == "go")
                {
                    Console.WriteLine("You are still unsure where to go.");
                    continue;
                }
                if (todo == "check ")
                {
                    Console.WriteLine("You checked the air, but there was nothing unusual.");
                    continue;
                }

    //----------------------------------------------------------------------------------------------------Your room zone------------------------------------------------------------------------------------------------------------------------

                if ((todo == "go your room" || todo == "go to your room") && RoomChange == 0)
                {
                    System.Console.WriteLine("\nYou're already in \u001b[36myour room\u001b[0m.\n");
                    continue;
                }
                else if ((todo == "go your room" || todo == "go to your room") && RoomChange != 0)
                {
                    System.Console.WriteLine("\nYou go to \u001b[36myour room\u001b[0m.\n");
                    RoomChange = 0;
                    continue;
                }
                if (todo == "check your room" && RoomChange == 0 && sink == false)
                {   
                    Console.WriteLine("\nYou blink your eyes open, the morning haze slowly lifting.");
                    Thread.Sleep(1000);
                    Console.WriteLine("The room comes into focus, its limited space becomes apparent.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Next to you, your \u001b[36mbed\u001b[0m offers a place of rest, and a small \u001b[36mbookshelf\u001b[0m stands behind, filled with a collection of books.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Sometimes, your gaze lingers on the \u001b[36mdesk\u001b[0m positioned beside the small \u001b[36mbookshelf\u001b[0m.\n");
                    continue;
                }
                if (todo == "check your room" && RoomChange == 0)
                {
                    System.Console.WriteLine("\nYou look around \u001b[36myour room\u001b[0m\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Because of the size of the apartment you live in, your room is not very wide.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Next to you, your \u001b[36mbed\u001b[0m offers a place of rest, and a small \u001b[36mbookshelf\u001b[0m stands behind, filled with a collection of books.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Sometimes, your gaze lingers on the \u001b[36mdesk\u001b[0m positioned beside the small \u001b[36mbookshelf\u001b[0m.\n");
                    continue;
                }
                if (todo == "check bed" && RoomChange == 0 && obj1 == true)
                {
                    System.Console.WriteLine("\nYou're already made your \u001b[36mbed\u001b[0m.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You don't need to do anything further.\n");
                    continue;
                }
                else if (todo == "check bed" && RoomChange == 0)
                {
                    System.Console.WriteLine("\nYou stare at the little mess on your \u001b[36mbed\u001b[0m.");
                    Thread.Sleep(1000);
                    System.Console.Write("You start make your \u001b[36mbed\u001b[0m");
                    loading();
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Done, all neat and tidy now.\n");
                    obj1 = true;
                    continue;
                }
                if (todo == "check bookshelf" && RoomChange == 0 && sink == false)
                {
                    System.Console.WriteLine("\nYou're not fully awake for checking the \u001b[36mbookshelf\u001b[0m; you might need to wash your face first.\n");
                    continue;
                }
                
                else if (todo =="check bookshelf" && RoomChange == 0 && book > 3)
                {
                    System.Console.WriteLine("\nYou've already found something.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You don't feel like trying to find a book anymore.\n");
                    continue;
                }
                else if (todo == "check bookshelf" && RoomChange == 0 && book == 3 && Ranname != "Lily")
                {
                    System.Console.WriteLine("\nYou sweep a glance at the \u001b[36mbookshelf\u001b[0m.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You try to find a book.");
                    Thread.Sleep(3000);
                    System.Console.WriteLine("After third time you some how made it.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You've found someone's \u001b[36mdiary\u001b[0m.\n");
                    book++;
                    diary = true;
                    continue;
                }
                else if (todo == "check bookshelf" && RoomChange == 0)
                {
                    System.Console.WriteLine("\nYou sweep a glance at the \u001b[36mbookshelf\u001b[0m.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You try to find a book.");
                    Thread.Sleep(3000);
                    System.Console.WriteLine("Nothing seems interesting, you decide to give up.\n");
                    book++;
                    continue;
                }
                if (todo == "check desk" && RoomChange == 0 && sink == false)
                {
                    System.Console.WriteLine("\nYou're not fully awake for checking the \u001b[36mdesk\u001b[0m; you might need to wash your face first.\n");
                    continue;
                }
                
                else if(todo == "check desk" && RoomChange == 0)
                {
                    System.Console.WriteLine("\nYou look at the table.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Except the alarm, there isn't much on your \u001b[36desk\u001b[0m.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Just a lamp and a \u001b[36mphotograph\u001b[0m of someone.\n");
                    continue;
                }
                if (todo == "check photograph" && RoomChange == 0 && sink == false)
                {
                    System.Console.WriteLine("\nYou're not fully awake for checking the \u001b[36mphotograph\u001b[0m; you might need to wash your face first.\n");
                    continue;
                }
                
                if (todo == "check photograph" && RoomChange == 0 && photo == true)
                {
                    System.Console.WriteLine("\nYou've already checked it.\n");
                    continue;
                }
                else if (todo == "check photograph" && RoomChange == 0)
                {
                    Console.WriteLine("\nYou take a closer look at the \u001b[36mphotograph\u001b[0m.");
                    Thread.Sleep(2000);
                    Console.WriteLine("The picture itself looks a bit blurry.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Still, you can see that there is a person in the picture.");
                    Thread.Sleep(2000);
                    Console.WriteLine("According to the attire, she seems to be a woman in young adulthood.");
                    Thread.Sleep(2000);
                    Console.WriteLine("However, no matter how hard you try, you can't specify who she is.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You look at the bottom of the picture.\n");
                    Thread.Sleep(1000);
                    Console.Write("There is text on it:");
                    Thread.Sleep(2000);
                    Console.WriteLine("'More than once.'\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("You're not sure what it means, so you put the \u001b[36mphotograph\u001b[0m back where it should be.\n");
                    photo = true;
                    continue;
                }
                if (todo == "check diary" && diary == true && attempt > 0)
                {
                    Console.WriteLine("\nYou've reached the secret end after " + attempt + " time(s)." );
                    Thread.Sleep(2000);
                    Console.WriteLine("As the narrator in this game, I, " + Ranname + ", want to express my gratitude for playing.\n");
                    Thread.Sleep(3000);
                    break;
                }

                if (todo == "check diary" && diary == true && attempt == 0)
                {
                    Console.WriteLine("\nYou've reached the secret end on your first playthrough.");
                    Thread.Sleep(2000);
                    Console.WriteLine("I hope you played fair without cheating.");
                    Thread.Sleep(1000);
                    Console.WriteLine("As the narrator in this game, I, " + Ranname + ", want to express my gratitude for playing.\n");
                    Thread.Sleep(3000);
                    break;
                }
    //----------------------------------------------------------------------------------------------------hallway zone------------------------------------------------------------------------------------------------------------------------

                if ((todo == "go hallway" || todo == "go to hallway") && RoomChange == 1)
                {
                    System.Console.WriteLine("\nYou're already in \u001b[36mhallway\u001b[0m.\n");
                    continue;
                }
                else if ((todo == "go hallway" || todo == "go to hallway") && RoomChange != 1)
                {
                    System.Console.WriteLine("\nYou go to the \u001b[36mhallway\u001b[0m.\n");
                    RoomChange = 1;
                    continue;
                }
                if (todo == "check hallway" && RoomChange == 1 && sink == false)
                {
                    System.Console.WriteLine("\nYou're not fully awake for checking the \u001b[36mhallway\u001b[0m; you might need to wash your face first.\n");
                    continue;
                }
                else if (todo == "check hallway" && RoomChange == 1)
                {
                    System.Console.WriteLine("\nYou look at the \u001b[36mhallway\u001b[0m.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You used to fantasize that this hallway could be long, endless.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Until you realize that it's too small to be endless.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("At the end of the hallway, there is just an \u001b[36mentry door\u001b[0m and wardrobe.\n");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Wait, why is the wardrobe here in the \u001b[36mhallway\u001b[0m?\n");
                    continue;
                }
                if (todo == "check entry door" && RoomChange == 1 && sink == false && attempt == 0)
                {
                    System.Console.WriteLine("\nYou're not fully...wait, how did you...!?\n");
                    continue;
                }
                if (todo == "check entry door" && RoomChange == 1 && sink == false && attempt > 0)
                {
                    System.Console.WriteLine("\nYou're not fully awake to check the \u001b[36mentry door\u001b[0. Your knowlegde from previous playthrough huh?\n");
                    continue;
                }

                else if (todo == "check entry door" && RoomChange == 1 && obj5 == true)
                {
                    System.Console.WriteLine("\nYou've already check the \u001b[36mentry door\u001b[0m.\n");
                    continue;
                }
                else if (todo == "check entry door" && RoomChange == 1)
                {
                    System.Console.Write("\nYou check the \u001b[36mentry door\u001b[0m.");
                    loading();
                    System.Console.Write("It's locked,");
                    Thread.Sleep(2000);
                    System.Console.WriteLine(" as usual.\n");
                    obj5 = true;
                    continue;
                }

    //----------------------------------------------------------------------------------------------------Living room zone------------------------------------------------------------------------------------------------------------------------

                if ((todo == "go living room" || todo == "go to living room") && RoomChange != 2 && sink == false)
                {
                    System.Console.WriteLine("\nYou're not fully awake to go there; you might need to wash your face first.\n");
                    continue;
                }
                else if ((todo == "go living room" || todo == "go to living room") && RoomChange == 2)
                {
                    System.Console.WriteLine("\nYou're already in \u001b[36mliving room\u001b[0m.\n");
                    continue;
                }
                else if ((todo == "go living room" || todo == "go to living room") && RoomChange != 2)
                {
                    System.Console.WriteLine("\nYou go to \u001b[36mlivning room\u001b[0m.\n");
                    RoomChange = 2;
                    continue;
                }
                if (todo == "check living room" && RoomChange == 2)
                {
                    System.Console.WriteLine("\nYou look around the \u001b[36mliving room\u001b[0m.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("This room is slightly larger than \u001b[36myour room\u001b[0m.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("There is a medium-sized flat-screen \u001b[36mTV\u001b[0m and a soft \u001b[36msofa\u001b[0m to sit and watch \u001b[36mTV\u001b[0m on.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("By the window, there is a small \u001b[36mflower\u001b[0m bed with different types of \u001b[36mflower\u001b[0ms mixed in it.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Light coming through the window makes the room look warm.\n");
                    continue;
                }
                if (todo == "check tv" && RoomChange == 2)
                {
                    Console.WriteLine("\nYou look at the \u001b[36mTV\u001b[0m.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("It's just an ordinary flat-screen \u001b[36mTV\u001b[0m.");
                    Thread.Sleep(1000);
                    Console.WriteLine("You don't feel like watching \u001b[36mTV\u001b[0m right now.\n");
                    continue;
                }
                if (todo == "check sofa" && RoomChange == 2 && sofa == true)
                {
                    System.Console.WriteLine("\nYou've already rested on it.\n");
                    continue;
                }
                else if (todo == "check sofa" && RoomChange == 2)
                {
                    Console.WriteLine("\nYou get closer to the \u001b[36msofa\u001b[0m.");
                    Thread.Sleep(1000);
                    Console.WriteLine("It looks so soft, making you want to sit on it.");
                    Thread.Sleep(1000);
                    Console.Write("You decide to sit on it for a moment");
                    loading();
                    Console.WriteLine("You feel better.\n");
                    sofa = true;
                    continue;
                }
                if ((todo == "check flower" || todo == "check flowers") && RoomChange == 2 && obj2 == true && obj3 == true)
                {
                    System.Console.WriteLine("\nThe \u001b[36mflower\u001b[0ms all look happy!\n");
                    continue;

                }
                if ((todo == "check flower" || todo == "check flowers") && RoomChange == 2 && obj2 == true && obj4 == true)
                {
                    Console.WriteLine("\nYou check the \u001b[36mflower\u001b[0ms.\n");
                    Thread.Sleep(1000);
                    Console.Write("You pick up the watering can and start watering them");
                    loading();
                    Thread.Sleep(2000);
                    Console.WriteLine("There are many types of \u001b[36mflower\u001b[0ms such as roses, daisies, and tulips.");
                    obj3 = true;
                    continue;
                }
                else if (todo == "check flower" || todo == "check flowers" && RoomChange == 2)
                {
                    System.Console.WriteLine("\nYou check the \u001b[36mflower\u001b[0ms.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("They seem healthy for now, you can water them later.\n");
                    continue;
                }

    //----------------------------------------------------------------------------------------------------Kitchen zone------------------------------------------------------------------------------------------------------------------------

                if ((todo == "go kitchen" || todo == "go to kitchen") && RoomChange != 3 && sink == false)
                {
                    System.Console.WriteLine("\nYou're not fully awake to go there; you might need to wash your face first.\n");
                    continue;
                }

                else if ((todo == "go kitchen" || todo == "go to kitchen") && RoomChange == 3)
                {
                    System.Console.WriteLine("\nYou're already in \u001b[36mkitchen\u001b[0m.\n");
                    continue;
                }
                else if ((todo == "go kitchen" || todo == "go to kitchen") && RoomChange != 3)
                {
                    System.Console.WriteLine("\nYou go to the \u001b[36mkitchen\u001b[0m.\n");
                    RoomChange = 3;
                    continue;
                }
                if (todo == "check kitchen" && RoomChange == 3)
                {
                    System.Console.WriteLine("\nYou check what do this small kitchen has.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("As expected, nothing much in the kitchen.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("A \u001b[36mtable\u001b[0m for eating, a cooking area, a \u001b[36mfridge\u001b[0m, and a \u001b[36mmicrowave\u001b[0m that you often use.\n");
                    continue;
                }
                if (todo == "check table" && RoomChange == 3 && foodWarm)
                {
                    Console.WriteLine("\nYou get closer to the \u001b[36mtable.\u001b[0m\n");
                    Thread.Sleep(1000);
                    Console.Write("You place your warm \u001b[36msandwich\u001b[0m on the plate and pour \u001b[36mmilk\u001b[0m into the cup");
                    loading();
                    Thread.Sleep(2000);
                    Console.Write("Although it's not enough to make you full,");
                    Thread.Sleep(1000);
                    Console.WriteLine(" it's better than nothing.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("You finished your meal.\n");
                    obj2 = true;
                    continue;
                }
                else if (todo == "check table" && RoomChange == 3)
                {
                    Console.WriteLine("\nYou look at the \u001b[36mtable\u001b[0m.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("It's just a normal \u001b[36mtable\u001b[0m that can fit a maximum of 2 people.\n");
                    continue;
                }
                if (todo == "check sandwich" && RoomChange == 3 && food == true && foodWarm == true) //kolla på smörgås efter man har varmat den.
                {
                    Console.WriteLine("\nYou look at the warm \u001b[36msandwich\u001b[0m in your hand.\n");
                    Thread.Sleep(2000);
                    Console.WriteLine("Now you just need to find a place to eat it.");
                    continue;
                }
                else if (todo == "check sandwich" && RoomChange == 3 && food == true)//kolla på smörgås
                {
                    Console.WriteLine("\nYou look at the cold \u001b[36msandwich\u001b[0m in your hand.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You don't like to eat something cold.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Find something to warm it up.\n");
                    continue;
                }
                if (todo == "check milk" && RoomChange == 3 && food == true)//kolla på mjölk
                {
                    Console.WriteLine("You look at the \u001b[36mmilk\u001b[0m in your hand.");
                    Thread.Sleep(1000);
                    Console.WriteLine("It says it's best before 4 days from now.\n");
                    continue;
                }

                if (todo == "check microwave" && RoomChange == 3 && foodWarm == true)//kolla micro efter varmat maten.
                {
                    System.Console.WriteLine("\nYou've already warmed up your food.\n");
                    continue;
                }
                else if (todo == "check microwave" && RoomChange == 3 && food == true && CheckMicro == true)//kolla micro igen efter man har mat.
                {
                    MicroDialog();
                    foodWarm = true;
                    continue;

                }
                else if (todo == "check microwave" && RoomChange == 3 && food == true)//kolla micro första gång men har mat.
                {
                    System.Console.WriteLine("\nYou take a closer look at the \u001b[36mmicrowave\u001b[0m.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("The worn appearance suggests that this \u001b[36mmicrowave\u001b[0m is frequently used.");
                    Thread.Sleep(2000);
                    MicroDialog();
                    foodWarm = true;
                    continue;
                }
                
                else if (todo == "check microwave" && RoomChange == 3) //kolla micro första gång utan att ha mat.
                {
                    System.Console.WriteLine("\nYou take a closer look at the \u001b[36mmicrowave\u001b[0m.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("The worn appearance suggests that this \u001b[36mmicrowave\u001b[0m is frequently used.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("You might need this later.\n");
                    CheckMicro = true;
                    continue;
                }

                if (todo == "check fridge" && RoomChange == 3 && food == true)
                {
                    System.Console.WriteLine("\nThat's all you've got for today.\n");
                    continue;
                }
                if (todo == "check fridge" && RoomChange == 3)
                {
                    Console.WriteLine("\nYou open the \u001b[36mfridge\u001b[0m.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("In front of you, there is a beacon \u001b[36msandwich\u001b[0m.");
                    Thread.Sleep(3000);
                    Console.WriteLine("On the side door of the \u001b[36mfridge\u001b[0m, there are some eggs and a \u001b[36mmilk\u001b[0m bottle.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Initially, you plan to make some fried eggs, but you don't want the \u001b[36msandwich\u001b[0m to go bad.");
                    Thread.Sleep(2000);
                    Console.WriteLine("So, you decide to eat the \u001b[36msandwich\u001b[0m for today.");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You grab a \u001b[36msandwich\u001b[0m and the \u001b[36mmilk\u001b[0m.\n");
                    food = true;
                    continue;
                }
                
    //----------------------------------------------------------------------------------------------------Bathroom zone------------------------------------------------------------------------------------------------------------------------
        
                if ((todo == "go bathroom" || todo == "go to bathroom") && RoomChange == 4)
                {
                    System.Console.WriteLine("\nYou're already in \u001b[36mbathroom\u001b[0m.\n");
                    continue;
                }
                else if ((todo == "go bathroom" || todo == "go to bathroom") && RoomChange != 4)
                {
                    System.Console.WriteLine("\nYou go to the \u001b[36mbathroom\u001b[0m.\n");
                    RoomChange = 4;
                    continue;
                }
                if (todo == "check bathroom" && RoomChange == 4)
                {
                    System.Console.WriteLine("\nYou check your \u001b[36mbathroom\u001b[0m.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Nothing unusual with it. It includes the \u001b[36msink\u001b[0m for washing your face,");
                    Thread.Sleep(2000);
                    System.Console.Write("the \u001b[36mtoilet\u001b[0m, and a \u001b[36mshower\u001b[0m.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine(" Just a normal \u001b[36mbathroom\u001b[0m.\n");
                    continue;
                }
                if (todo == "check sink" && RoomChange == 4 && sink == true)
                {
                    System.Console.WriteLine("\nYou've already washed your face.\n");
                    continue;
                }
                else if (todo == "check sink" && RoomChange == 4)
                {
                    System.Console.WriteLine("\nYou take a look at the \u001b[36msink\u001b[0m.\n");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You glance at the mirror above the \u001b[36msink\u001b[0m.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("your face looks tired, which is normal for someone who just woke up.");
                    Thread.Sleep(2000);
                    System.Console.Write("You turned on the faucet and start washing your face");
                    loading();
                    System.Console.WriteLine("Done.");
                    Thread.Sleep(2000);
                    System.Console.Write("You turned off the fuacet and look again at the mirror.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine(" Your face looks now better.\n");
                    sink = true;
                    continue;
                }
                if (todo == "check toilet" && RoomChange == 4)
                {
                    Console.WriteLine("\nYou glance at the \u001b[36mtoilet\u001b[0m.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("The thought of using it doesn't appeal to you right now.");
                    Thread.Sleep(1000);
                    Console.WriteLine("You decide to hold off for the moment.\n");
                    continue;
                }
                if (todo == "check shower" && RoomChange == 4 && obj4 == true)
                {
                    System.Console.WriteLine("\nYou've already showered.\n");
                    continue;
                } 
                if (todo == "check shower" && RoomChange == 4 && obj2 == true)
                {
                    Console.WriteLine("\nYou open the \u001b[36mshower\u001b[0m curtain.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("The warm water cascades, providing a refreshing sensation.");
                    Thread.Sleep(2000);
                    Console.Write("As the steam envelops you, you take a moment to relax and rejuvenate");
                    loading();
                    Thread.Sleep(2000);
                    System.Console.WriteLine("You feel even fresher now.\n");
                    obj4 = true;
                    continue;

                }
                else if (todo == "check shower" && RoomChange == 4 )
                {
                    Console.WriteLine("\nYou open the \u001b[36mshower\u001b[0m curtain.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("But a growl from your stomach stops your thought.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("You decide to eat something first.\n");
                    continue;
                }
    //--------------------------------------------------------------------------------------------Ending(s) zone------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (todo == "doall")
                {
                    obj1 = true;
                    obj2 = true;
                    obj3 = true;
                    obj4 = true;
                    obj5 = true;
                }
                
                if (obj1 && obj2 && obj3 && obj4 && obj5 && attempt > 0 && Ranname == "Zack")
                {
                    EndDialog();
                    System.Console.WriteLine("Hmm...");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("It might be too hard without some clues!");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Let me think...");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Oh! That alarm, isn't it so annoying?");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Why don't you try to slam it?");
                    Thread.Sleep(1000);
                    System.Console.WriteLine("Do you want to retry? (Y/N)");
                    yesno();
                    Console.Clear();
                    break;
                }
                if (obj1 && obj2 && obj3 && obj4 && obj5 && attempt > 0 && Ranname == "Lily")
                {
                    EndDialog();
                    System.Console.WriteLine("However, I can give you another chance!");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Would you like to accept it? (Y/N)");
                    yesno();
                    Thread.Sleep(2000);
                    System.Console.WriteLine("\nI wonder if my diary is still in bookshelf...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                    
                }
                if (obj1 && obj2 && obj3 && obj4 && obj5 && Ranname == "Christ")
                {
                    EndDialog();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Have you even attempted to make a change?");
                    Thread.Sleep(1000);
                    Console.WriteLine("I sense a familiar pattern, haven't I?");
                    Thread.Sleep(1000);
                    Console.WriteLine("You've exhausted your chances.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Not everyone is granted as many opportunities as you have.");
                    Thread.Sleep(3000);
                    break;
                }
                else if (obj1 && obj2 && obj3 && obj4 && obj5 && Ranname != "Christ")
                {
                    EndDialog();
                    System.Console.WriteLine("However, I can give you another chance unlike Christ.");
                    Thread.Sleep(2000);
                    System.Console.WriteLine("Would you like to accept it? (Y/N)\n");
                    yesno();
                    Console.Clear();
                    break;

                }
                
            
                



                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                if ((todo == "check your room" && RoomChange != 0)||
                        (todo == "check hallway" && RoomChange != 1)||
                        (todo == "check living room" && RoomChange != 2)||
                        (todo == "check kitchen" && RoomChange != 3)||
                        (todo == "check bathroom" && RoomChange != 4))
                {
                    System.Console.WriteLine("\nYou ask youself: How can I check if I am not there?\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("\nYou are wondering what to do.\n");
                    continue;
                }
                
            }  
        }
    } 

}   


















//----------------------------------------------------------------------------------------------------Functions zone------------------------------------------------------------------------------------------------------------------------




static void processing()
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine();
    System.Console.Write("System is processing");
    loading();
    Console.ResetColor();
    Thread.Sleep(2000);
}

static void loading()
{
    
    for (int i = 0; i < 2; i++)
    {
        Thread.Sleep(2000);
        Console.Write(".");
        
    }
    Thread.Sleep(2000);
    System.Console.WriteLine(".");
}
void errorrep()
{
    Console.ForegroundColor = ConsoleColor.Red;
    List<string> errors = new List<string> { "System error.", "This is not right.", "I warned you.", "YOU BASTARD!!", "This is your responsibility." };

        foreach (string error in errors)
        {
            for (int i = 0; i < 100; i++)
            {
                
                Thread.Sleep(10);
                Console.WriteLine(error);
                
            }
        }
        Thread.Sleep(2000);
        System.Console.WriteLine("Zack has been deleted.");
        Thread.Sleep(2000);
        Console.Clear();
        zack = false;
        re = true;

    Console.ResetColor();
}




void task()
{

    System.Console.WriteLine("Things you need to do:\n");
    Thread.Sleep(1000);
    if (obj1 == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Make the bed. (Completed)");
        Console.ResetColor();
    }
    else
    {
        System.Console.WriteLine("Make the bed.");
    }
    if (obj2 == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Eat something. (Completed)");
        Console.ResetColor();
    }
    else
    {
        System.Console.WriteLine("Eat something.");
    }
    if (obj3 == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Water the flowers. (Completed)");
        Console.ResetColor();
    }
    else
    {
        System.Console.WriteLine("Water the flowers.");
    }
    if (obj4 == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Shower. (Completed)");
        Console.ResetColor();
    }
    else
    {
        System.Console.WriteLine("Shower.");
    }
    if (obj5 == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Check the entry door. (Completed)");
        Console.ResetColor();
    }
    else
    {
        System.Console.WriteLine("Check the entry door.\n");
    }
}
static void MicroDialog()
{
    Console.WriteLine("You put the \u001b[36msandwich\u001b[0m into the \u001b[36mmicrowave\u001b[0m.");
    Thread.Sleep(1000);
    Console.WriteLine("You press the '30' sec button on the \u001b[36mmicrowave\u001b[0m twice.");
    Thread.Sleep(1000);
    Console.Write("This may take some time");
    loading();
    Console.WriteLine("*Ding* The sound of the \u001b[36mmicrowave\u001b[0m breaks the silence.");
    Thread.Sleep(2000);
    Console.WriteLine("You pick up the \u001b[36msandwich\u001b[0m.\n");
    
}
void EndDialog()
{
    System.Console.WriteLine("\nNow, you've completed your task for today.\n");
    Thread.Sleep(2000);
    System.Console.WriteLine("You decide to go back to your room.");
    Thread.Sleep(2000);
    System.Console.WriteLine("You picked up the blanket that you folded not too long ago.");
    Thread.Sleep(2000);
    System.Console.Write("You lay down on the bed. ");
    Thread.Sleep(1000);
    System.Console.WriteLine("Close your eyes.");
    Thread.Sleep(3000);
    System.Console.Write("Everything you do.");
    Thread.Sleep(2000);
    System.Console.WriteLine(" Just same \u001b[31mas usual\u001b[0m.\n");
    obj1 = false;
    obj2 = false;
    obj3 = false;
    obj4 = false;
    obj5 = false;
    sofa = false;
    photo = false;
    food = false;
    CheckMicro = false;
    foodWarm = false;
    sink = false;
    RoomChange = 0;
    attempt++;
    Thread.Sleep(3000);
    

}
void yesno()
{
    while(true)
    {
        yn = Console.ReadLine().ToLower();

        if(yn == "yes" || yn == "y")
        {
            System.Console.WriteLine("\nAlright, if luck is on your side, we might meet again.\n");
            re = true;
            break;
        }
        else if(yn == "no" || yn == "n")
        {
            System.Console.WriteLine("I respect your decision. Feel free to return whenever you're ready.");
            Thread.Sleep(2000);
            System.Console.WriteLine("Thanks for playing.");
            break;
        }
        else
        {
            System.Console.WriteLine("Please answer the question.");
            continue;
        }
    }
}
