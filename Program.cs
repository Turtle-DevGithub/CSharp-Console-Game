using System;
 
 
namespace ConsoleGame
{
   public class Program
   {
       public static void Main(string[] args)
       {
       Start();
     
       }
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
          Console.WriteLine("Not Made Yet");
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
   }
}

