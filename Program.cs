using System;
 
 
namespace ConsoleGame
{
   public class Program
   {
       public static void Main(string[] args)
       {
       Start();
       static void Start() {
           Console.Clear();
               Console.WriteLine(@"
__          __  _                         
\ \        / / | |                        
 \ \  /\  / /__| | ___ ___  _ __ ___   ___
  \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \
   \  /\  /  __/ | (_| (_) | | | | | |  __/
    \/  \/ \___|_|\___\___/|_| |_| |_|\___|
   
    Start Game(1)
    How to play(2)
      ");
      string act = Console.ReadLine();
      if (act == "1") {
          d1();
      } else if (act == "2") {
          htp();
      } else {
          Console.WriteLine("Action not Found");
       Start();
      }
     
       }
       static void htp() {
        Console.Clear();
        Console.WriteLine(@"
 _    _                 _          _____  _            
| |  | |               | |        |  __ \| |           
| |__| | _____      __ | |_ ___   | |__) | | __ _ _   _
|  __  |/ _ \ \ /\ / / | __/ _ \  |  ___/| |/ _` | | | |
| |  | | (_) \ V  V /  | || (_) | | |    | | (_| | |_| |
|_|  |_|\___/ \_/\_/    \__\___/  |_|    |_|\__,_|\__, |
                                                   __/ |
                                                  |___/
       
        If a prompt asks you to imput a number (e.x. Start Game(1)) imput the number shown in the parentheses to complete the action
 
        If you type a number or letter that was not a possible imput, nothing will happen(or maybe something worse)
 
        Now, you figure out the rest
       
        Exit(1)
        ");
        string act = Console.ReadLine();
      
        if (act == "1") {
               Start();
        } else {
            Console.WriteLine("Command not found");
            htp();
        }
       }
       static void d1() {
           Console.Clear();
           Console.WriteLine("As you slowly wake up from a dark cave, you have many thoughts");
           System.Threading.Thread.Sleep(2300);
           Console.WriteLine("You think to yourself, 'Where am I? What is this?' When in reality this is the start of your new adventure, and the start of a poorly scripted game by a man who claims to be a turtle");
           System.Threading.Thread.Sleep(4000);
           Console.WriteLine(@"Continue?(1) (You don't have an option)");
           string act = Console.ReadLine();

           if (act == "1") {
               d2();
           } else {
               Console.Clear();
               Console.WriteLine(@"I told you that you didn't have any other option, so why did you type something other than the option provided? You are now stuck in the dark abis forever(Or untill you restart the program)");
           }
       }
       static void d2() {
           Console.Clear();
           Console.WriteLine(@"
           You wake up inside the cave and you have two options 

           Leave Cave(1)
           Stay in cave(2)");
           string act = Console.ReadLine();
           if (act == "1") {
               d3();
           } else if (act == "2") {
               Console.Clear();
               Console.WriteLine(@"
               Why did you stay inside the cave, do you just not want to make progress in the game?

               Leave Cave (1)");
               act = Console.ReadLine();
               if (act == "1") {
                   d3();
               } else {
                   d2();
               }

           }
       }
       static void d3() {
           Console.Clear();
           Console.WriteLine(@"
           
___________________________________________________________________________________________________________________________________
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|               ______                                 |                          |                                                |
|              /  __  \                                |             |            |                                                |
|              |_|  |_|                                |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |                          |                                       _________|
|                                                      |             |            |                          ___________ |         |
|                                                      |                          |                         |                      |
|                                                      |             |            |                  ______|                       |
|                                                      |                          |                  |        <--  you are here    |
|                                                      |             |            |               __|                              |      
|_______________________________________________________________________________________________ |_________________________________|                           


Enter ominous hut(1)  
           ");
           string act = Console.ReadLine();
           if (act == "1") {
               Console.Clear();
             Console.WriteLine(@"
             As you slowly creep into the hut you see and old man and he tells you 'It is dangerous to go alone! Take this.'
             You see him slowly  hand you a sharp sword 
             You can now use the sword to attack enemies!
             
             Exit hut(1)");
             string act2 = Console.ReadLine(); 
             if (act2 == "1") {
                 d4();
             }
           } else {
               d3();
           }

}
static void d4() {
    Console.Clear();
    Console.WriteLine("You quickly exit the hut with your new sword");
    System.Threading.Thread.Sleep(4000);
    Console.Clear();
    Console.WriteLine(@"
    ___________________________________________________________________________________________________________________________________
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|               ______                                 |                          |                                                |
|              /  __  \       <-- you are here         |             |            |                                                |
|              |_|  |_|                                |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |                          |                                       _________|
|                                                      |             |            |                          ___________ |         |
|                                                      |                          |                         |                      |
|                                                      |             |            |                  ______|                       |
|                                                      |                          |                  |                             |
|                                                      |             |            |               __|                              |      
|_______________________________________________________________________________________________ |_________________________________| 

Go up big road(1)
Retreat to cave(2)");
string act = Console.ReadLine();
if (act == "1") {
    d5();
} else if (act == "2") {
    Console.Clear();
    Console.WriteLine(@"Just the thought that someone will go out of their way to not make progress in the game

    Go up big road(1)");
    string act2 = Console.ReadLine();
    if (act2 == "1") {
        d5();
    } else {
        d4();
    }
}
}
static void d5() {
    Console.Clear();
    Console.WriteLine("Game not fully built");
}

       
   }
   }
}

