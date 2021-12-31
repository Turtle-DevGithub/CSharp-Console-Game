using System;
using System.Threading;
 
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
           Console.WriteLine(@"Continue?(1) (You don't have an option");
           string act = Console.ReadLine();

           if (act == "1") {
               d2();
           } else if (act == "10") {
               d10();
           } 
           else {
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
    Console.WriteLine("You start to walk forwards, you see something in the distance...");
    System.Threading.Thread.Sleep(4000);
    Console.WriteLine(@"
___________________________________________________________________________________________________________________________________
|                                                                                                                                  |
|                                                       ==========================                                                 |
|               ______                                 |                          |        _____                                   |
|              /  __  \           _____                |             |            |       /  _  \                                  |
|              |_|  |_|          /     \               |                          |       | | | |                                  |
|                                |  _  |               |             |            |                                                |
|                  _____         | | | |               |                          |                                                |
|                 /  _  \                              |             |            |                                                |
|                 |_| |_|                              |                          |                    _____                       |
|                  __________                          |             |            |                   /  _  \                      |
|                 /    __    \                         |                          |                   | | | |                      |
|                 |___|  |___|                         |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |            (*-*)         |                                                |
|                                                      |             |            |                                                |      
|_________________________________________________You_Are_Here_-->_________________________________________________________________|   
    ");
    Thread.Sleep(6000);
    Console.Clear();
    Console.WriteLine("As you stand there, looking at the creature in awe, It jumps at you! (battle initiated)");
    Thread.Sleep(4000);
    Console.Clear();
    Console.WriteLine(@"
    ____________________________________________________
   |  hp(100/100)         enemy hp(50/50)               |
   |                                                    |
   |           ___                                      |
   |          ('-')              (*-*)                  |
   |          --|--                                     |   
   |            |                                       | 
   |___________/_\______________________________________| 
   |                       Moves:                       |
   |  1.Hit with sword     3.Try to pet it              |              
   |__2.Stand_Still________4.Jump_at_it_________________| 
    ");
    string act = Console.ReadLine();
    if (act == "1") {
      d6(); 
    } else if (act == "2") {
        Console.Clear();
        Console.WriteLine(@"
 __     __               _ _          _       
 \ \   / /              | (_)        | |      
  \ \_/ /__  _   _    __| |_  ___  __| |      
   \   / _ \| | | |  / _` | |/ _ \/ _` |      
    | | (_) | |_| | | (_| | |  __/ (_| |_ _ _ 
    |_|\___/ \__,_|  \__,_|_|\___|\__,_(_|_|_)

    The furrball charged at you, and bit you in the face

    Continue from last save(1)
                                              ");
        string act2 = Console.ReadLine();
        d5();                                      
    } else if (act == "3") {
        Console.Clear();
        Console.WriteLine(@"
 __     __               _ _          _       
 \ \   / /              | (_)        | |      
  \ \_/ /__  _   _    __| |_  ___  __| |      
   \   / _ \| | | |  / _` | |/ _ \/ _` |      
    | | (_) | |_| | | (_| | |  __/ (_| |_ _ _ 
    |_|\___/ \__,_|  \__,_|_|\___|\__,_(_|_|_)

    You tried to pet the furrball, but it bit you in the testicles

    Continue from last save(1)
                                              ");
        string act3 = Console.ReadLine();
        d5();                                      
    } else if (act == "4") {
        Console.Clear();
        Console.WriteLine(@"
 __     __               _ _          _       
 \ \   / /              | (_)        | |      
  \ \_/ /__  _   _    __| |_  ___  __| |      
   \   / _ \| | | |  / _` | |/ _ \/ _` |      
    | | (_) | |_| | | (_| | |  __/ (_| |_ _ _ 
    |_|\___/ \__,_|  \__,_|_|\___|\__,_(_|_|_)

    You jumped at it doing 3 damage, but it bit you in the eye

    Continue from last save(1)
                                              ");
        string act4 = Console.ReadLine();
        d5();                                      
    } else {
        d5();
    }
}
static void d6() {
    Console.Clear();
    Console.WriteLine(@"You beat the enemy!");
    Thread.Sleep(5000);
    Console.Clear();
    Console.WriteLine(@"
___________________________________________________________________________________________________________________________________
|                                                                                                                                  |
|                                                       ==========================                                                 |
|               ______                                 |                          |        _____                                   |
|              /  __  \           _____                |             |            |       /  _  \                                  |
|              |_|  |_|          /     \               |                          |       | | | |                                  |
|                                |  _  |               |             |            |                                                |
|                  _____         | | | |               |                  (' ')   |                                                |
|                 /  _  \                              |             |            |                                                |
|                 |_| |_|                              |                          |                    _____                       |
|                  __________                          |             |            |                   /  _  \                      |
|                 /    __    \                         |                          |                   | | | |                      |
|                 |___|  |___|                         |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|                                                      | You Are here-->          |                                                |
|                                                      |             |            |                                                |      
|______________________________________________________|__________________________|________________________________________________|");
Thread.Sleep(6000);
Console.Clear();
Console.WriteLine(@"
Skip Cutscene(1)
Watch Cutscene(2)
");
string act = Console.ReadLine();
if (act == "1") {
    d8();
} else {
    Console.Clear();
   Console.WriteLine("You see an old man in the distance");
Thread.Sleep(1500);
Console.WriteLine("He slowly walks toward you and he begins to explain...");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("Ah, I see you have awakened from your slumber");
Thread.Sleep(2000);
Console.WriteLine("You seem comfused there, let me fill you in");
Thread.Sleep(2000);
Console.WriteLine("You have been asleep for 20 years");
Thread.Sleep(3000);
Console.WriteLine("'What?' you say, very confused 'First of all, I don't even know who you ar-");
Thread.Sleep(3000);
Console.WriteLine("My name is sir Jean Boucicaut, your name is Luis Bourbon previous king of this land");
Thread.Sleep(2000);
Console.WriteLine("You've got to be kidding me, King of this old town. Stop wasting my ti-");
Thread.Sleep(2000);
Console.WriteLine("He hands you what looks to be an old sheild with a large red bird on it");
Thread.Sleep(1000);
Console.WriteLine("This was your old sheild from when you used to be king, now do you trust me?");
Thread.Sleep(5000);
Console.WriteLine("Ok, I trust you, what do you have to tell me");
Thread.Sleep(2300);
d7(); 
}

}
static void d7() {
    Console.Clear();
    Console.WriteLine("This used to be a fruitful town, with lush gardens, happy people, and you were in charge ");
    Thread.Sleep(4000);
    Console.WriteLine("You had five knights, all of which followed your every command");
    Thread.Sleep(3000);
    Console.WriteLine("But one of them got very greedy, he thought to himself, 'I hate being a knight, I always get put in the king's shadow!'");
    Thread.Sleep(5000);
    Console.Clear();
    Console.WriteLine("So he poisoned all of the knights into an eternal slumber, and banashed you into a dark cave and made you drink a special fluid, that made you go to sleep");
    Thread.Sleep(4000);
    Console.WriteLine("Nobody knew what had happened, but they decided to make the evil knight the king, as he was the last one with power");
    Thread.Sleep(5000);
    Console.WriteLine("The evil night became the dictator of the land and he made everyone his slave!");
    Thread.Sleep(3000);
    Console.WriteLine("Now, 20 years later you have awakened and you need to overtrown this dictator!");
    Thread.Sleep(4000); 
    Console.WriteLine("Hurry! Hurry! awaken your previous knights and overthrow this dictator!");
    Thread.Sleep(4000);
    d8();
}
static void d8() {
Console.Clear();
Console.WriteLine(@"
  _______ _              _                                     _                _                 
 |__   __| |            (_)                                   | |              (_)                
    | |  | |__   ___     _  ___  _   _ _ __ _ __   ___ _   _  | |__   ___  __ _ _ _ __  ___       
    | |  | '_ \ / _ \   | |/ _ \| | | | '__| '_ \ / _ \ | | | | '_ \ / _ \/ _` | | '_ \/ __|      
    | |  | | | |  __/   | | (_) | |_| | |  | | | |  __/ |_| | | |_) |  __/ (_| | | | | \__ \_ _ _ 
    |_|  |_| |_|\___|   | |\___/ \__,_|_|  |_| |_|\___|\__, | |_.__/ \___|\__, |_|_| |_|___(_|_|_)
                       _/ |                             __/ |              __/ |                  
                      |__/                             |___/              |___/             

 You have been tasked by an old man to find your knights and defeat the dictator!

 P.S. If you quit within the game, you lose all progress, so keep the game open if you need to take brakes

 Continue(1)
 Exit(2)                     
                        ");
   string act = Console.ReadLine();
   if (act == "1") {
       d9();
   } else if (act == "2") {

   } else {
       d9();
   }                   

}
 static void d9() {
Console.WriteLine(@"
___________________________________________________________________________________________________________________________________
|                                                                                                                                  |
|                                                       ==========================                                                 |
|               ______                                 |                          |        _____                                   |
|              /  __  \           _____                |             |            |       /  _  \                                  |
|              |_|  |_|          /     \               |                          |       | | | |                                  |
|                                |  _  |               |             |            |                                                |
|                  _____         | | | |               |                          |                                                |
|                 /  _  \                              |             |            |                                                |
|                 |_| |_|                              |                          |                    _____                       |
|                  __________                          |             |            |                   /  _  \                      |
|                 /    __    \                         |                          |                   | | | |                      |
|                 |___|  |___|                         |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |
|                                                      |                          |                                                |
|                                                      |             |            |                                                |      
|______________________________________________________|__________________________|________________________________________________|");
Thread.Sleep(1000);
Console.WriteLine("You stand there confused, but because of the creep you are, you decide to go to one of the houses");
Thread.Sleep(2300);
Console.Clear();
Console.WriteLine("you walk inside one of the houses, only to find that there is nobody inside, but there is a large hole in the ground");
Thread.Sleep(4000);
Console.WriteLine("You decide that the next logical step is to jump inside the hole");
Thread.Sleep(2000);
Console.WriteLine("When you jump in the whole, you land in water, but you look forward to see a large cavern in front of you");
d10();
 }
 static void d10() {
     Console.Clear();
     Console.WriteLine(@"
___________________________________________________________________________________________________________________________________
|                         |  (1)   |                                                                                               |
|                         |        |                                                                                               |
|                         |        |                                                                                               |
|                         |        |                                                                                               |
|_________________________|        |_______________________________________                                                        |
|                                                                         |                                                        |
|                                                                     (3) |                                                        |
|______________________________________________        ___________________|                                                        |
|                                             |       |                                                                            |
|                                             |       |                                                                            |
|                                             |       |                                                                            |
|                                             |       |                                                                            |
|                                             |       |                                                                            |
|                                             |       |                                                                            |
|                                             |       |                                                                            |
|                                             |       |                                                                            |      
|_____________________________________________|__(2)__|____________________________________________________________________________|

Choose which tunnel you want to go through");
string act = Console.ReadLine();
if (act == "1") {
    d10_1();
} else if (act == "2") {
    d10_2();
} else if (act == "3") {
    d10_3();
} else {
    d10();
}
 
 } static void d10_1() {
     Console.Clear();
     int hp = 100;
     int enemyhp = 75;
    Console.WriteLine("As you slowly walk into the first tunnel you see a dark shadow in the corner of a dark room (Batte initated)");
    Thread.Sleep(2300);
    do {
        Console.Clear();
     Console.WriteLine($@"
    ____________________________________________________
   |  hp({hp}/100)         enemy hp({enemyhp}/75)               |
   |                                                    |
   |           ___                                      |
   |          ('-')              (.-.)                  |
   |          --|--                                     |   
   |            |                                       | 
   |___________/_\______________________________________| 
   |                       Moves:                       |
   |  1.Hit with sword     2.Stand still                |              
   |____________________________________________________| 
     ");
     string act = Console.ReadLine();
     if (act == "1") {
         Console.Clear();
         Console.WriteLine("You succesfully hit a head with a sword! it did 30 damage...");
         Thread.Sleep(2300);
         enemyhp -= 20;
         Console.Clear();
         Console.WriteLine("The head hit you doing 15 damage!");
         Thread.Sleep(2300);
         hp -= 15;
         Console.Clear();
     } else if (act == "2") {
         Console.Clear();
         
         Console.WriteLine("ok buddy, that thing hit you in the head, dealing 30 damage due to a critical hit, what did you expect");
         Thread.Sleep(2300);
         hp -= 30;
     }
    } while (hp > 0 && enemyhp > 0);
    if (hp > 0) {
       Console.WriteLine(@"
    You killed the- watever it is!
    Go back(1)"); 
    } else {
        Console.WriteLine(@"
 __     __               _ _          _       
 \ \   / /              | (_)        | |      
  \ \_/ /__  _   _    __| |_  ___  __| |      
   \   / _ \| | | |  / _` | |/ _ \/ _` |      
    | | (_) | |_| | | (_| | |  __/ (_| |_ _ _ 
    |_|\___/ \__,_|  \__,_|_|\___|\__,_(_|_|_)

    how did you die? this is so easy man, what it wrong with you

    Go back to last battle(1)
");
string asoihdpaopihfpoiusdhfpaosiduhfpoaisdhfpoaishdfpioajsdfpoiajsdpfoijasdpofi = Console.ReadLine();
d10_1();
    }
    
    string act2 = Console.ReadLine();
    d10();
 } static void d10_2() {
     Console.Clear();
     int hp = 100;
     int enemyhp = 100;
     Console.WriteLine("You go to the second tunnel and see something in the corner of a dark room (Battle Initiated!)");
     Thread.Sleep(2300);
         string attack1 = "Hit with sword";
         int phase = 1;
     do {
         Console.Clear();
         Console.WriteLine(@$"
    ____________________________________________________
   |  hp({hp}/100)         enemy hp({enemyhp}/100)               |
   |                                                    |
   |           ___                                      |
   |          ('-')              (-_-)                  |
   |          --|--                                     |   
   |            |                                       | 
   |___________/_\______________________________________| 
   |                       Moves:                       |
   |  1.{attack1}     2.Punch                      |              
   |____________________________________________________| ");
   string act = Console.ReadLine();
   if (phase == 1 && act == "1") {
       Console.Clear();
       Console.WriteLine(@"
       You hit the ball thing with your sword doing 25 damage!
       But sadly you sword broke(You'll get it back after the battle)");
       Thread.Sleep(2300);
       Console.Clear();
       Console.WriteLine("It hit you back dealing 30 damage");
       phase++;
       attack1 = "Kick";
       hp -= 30;
       enemyhp -= 25;
       Thread.Sleep(5000);
   } else if (phase == 2 && act == "1") {
       Console.Clear();
       Console.WriteLine(@"
       You kicked the furry doing 10 damage");
       Thread.Sleep(2300);
       Console.Clear();
       Console.WriteLine("It hit you back dealing 20 damage!");
       hp -= 20;
       enemyhp -= 10;
   } else {
       Console.Clear();
       Console.WriteLine(@"
       You punched the furry doing 20 damage!");
       Thread.Sleep(2300);
       Console.WriteLine("It hit you back dealing 15 damage!");
       hp -= 15;
       enemyhp -= 20;
       Thread.Sleep(5000);
   }
     }while (hp > 0 && enemyhp > 0);
     if (hp > 0) {
         Console.WriteLine(@"
         You beat the furry!
         
    
         Leave Cave(1)");
     } else {
         Console.WriteLine(@"
__     __               _ _          _       
 \ \   / /              | (_)        | |      
  \ \_/ /__  _   _    __| |_  ___  __| |      
   \   / _ \| | | |  / _` | |/ _ \/ _` |      
    | | (_) | |_| | | (_| | |  __/ (_| |_ _ _ 
    |_|\___/ \__,_|  \__,_|_|\___|\__,_(_|_|_)

    You died to a virtual circle, good for you

    Go back to last battle(1)");
    string act = Console.ReadLine();
    d10_2();
     }
 } static void d10_3() {
     Console.Clear();
     Console.WriteLine("ah at last you have come here says a voice in the corner");
     Thread.Sleep(2300);
     Console.WriteLine("You four loyal nights are right there to my side, but legend says that only the true king can ressurect them");
     Thread.Sleep(5000);
     Console.Clear();
     Console.WriteLine("Go there, put your hand on their chest and focus all of your energy to your hand");
     Thread.Sleep(3000);
     Console.WriteLine("You repeat this process for all four of the nights and they all wake up.");
     Thread.Sleep(2300);
     Console.WriteLine("Now you can leave this cave, and go and fight this tyrant that has been ruling our town for far too long!");
     Thread.Sleep(5000);
     Console.Clear();
     Console.WriteLine(@"
     I highly advise for you to go back and visit any rooms you haven't been to 
     
     Leave tavern(1)
     Go back to rooms(2)");
     string act = Console.ReadLine();
     if (act == "1") {
         d11();
     } else {
         d10();
     }
 }
 static void d11() {
     Console.Clear();
 }
 } 
   }
   }

