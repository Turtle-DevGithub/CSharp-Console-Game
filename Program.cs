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
           } else if (act == "11") {
               d11();
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
|______________________________________________________|__________________________|________________________________________________|

You walk out of the house, not knowing where to go, but one of the knights tells you to go farther up the road to reach the potion shop");
Thread.Sleep(5000);
Console.Clear();
Console.WriteLine(@"
___________________________________________________________________________________________________________________________________
|                                                                                                                                  |
|                                                                                                                                  |
|                                 /\                                                                                               |
|                                /  \                                                                                              |
|                               /    \                                                                                             |
|                              /      \                                                                                            |
|                             /        \                                                                                           |
|                            /          \                                                                                          |
|                           /|          |\                                                                                         |
|                            |   ____   |                                                                                          |
|                            |   |  |   |                                                                                          |
|                            |___|__|___|                                                                                          |
|                                |  |                                                                                              |
|                                \  \                                                                                              |
|                                 \  \_____________________                                                                        |
|                                  |____________________  |                                                                        |      
|_______________________________________________________|_|________________________________________________________________________|

You walk up the path and see the potion shop in the distance 
");
Thread.Sleep(5000);
Console.Clear();
Console.WriteLine("The knight gives you 3 gold coins and tells you to buy some potions");
int gold = 3;
int sp = 0;
int hp = 0;
int dp = 0;
int pp = 0;
int wp = 0;
Thread.Sleep(2300);
Console.Clear();
do {
    Console.Clear();
    Console.WriteLine($@"
   ______________________________________________________
   |                                                 ${gold}  |
   |                                                    |
   |   1: strength potion      2: health potion         |
   |                                                    |
   |   3: defence potion       4: posion potion         |   
   |                                                    | 
   |   5: weakness potion      6: potion info           | 
   |                                                    |
   |                type an action                      |              
   |____________________________________________________| ");

   string act = Console.ReadLine();
   if (act == "1") {
       if (sp == 0) {   
           Console.Clear();
           Console.WriteLine("Are you sure you want to buy a strength potion? [y/n]");
           string act2 = Console.ReadLine();
           if (act2 == "y") {
               sp = 1;
               gold--;
           } else {

           }

       } else {
           Console.Clear();
           Console.WriteLine("You've already bought this");
           Thread.Sleep(3000);
       }
   } else if (act == "2") {
       if (hp == 0) {   
           Console.Clear();
           Console.WriteLine("Are you sure you want to buy a health potion? [y/n]");
           string act3 = Console.ReadLine();
           if (act3 == "y") {
               hp = 1;
               gold--;
           } else {

           }

       } else {
           Console.Clear();
           Console.WriteLine("You've already bought this");
           Thread.Sleep(3000);
       }
   } else if (act == "3") {
       if (dp == 0) {   
           Console.Clear();
           Console.WriteLine("Are you sure you want to buy a defence potion? [y/n]");
           string act2 = Console.ReadLine();
           if (act2 == "y") {
               dp = 1;
               gold--;
           } else {

           }

       } else {
           Console.Clear();
           Console.WriteLine("You've already bought this");
           Thread.Sleep(3000);
       }
   } else if (act == "4") {
       if (pp == 0) {   
           Console.Clear();
           Console.WriteLine("Are you sure you want to buy a poison potion? [y/n]");
           string act2 = Console.ReadLine();
           if (act2 == "y") {
               pp = 1;
               gold--;
           } else {

           }

       } else {
           Console.Clear();
           Console.WriteLine("You've already bought this");
           Thread.Sleep(3000);
       }
   } else if (act == "5") {
       if (wp == 0) {   
           Console.Clear();
           Console.WriteLine("Are you sure you want to buy a weakness potion? [y/n]");
           string act2 = Console.ReadLine();
           if (act2 == "y") {
               wp = 1;
               gold--;
           } else {

           }

       } else {
           Console.Clear();
           Console.WriteLine("You've already bought this");
           Thread.Sleep(3000);
       }
   } else {
       Console.Clear();
       Console.WriteLine(@"
       Strength potion: lets you do 20 more damage per hit
       Health potion: heals 50 hp instantly
       Defence potion: lets you take 20 less damage from each attack
       Poison potion: takes 20 damage from enemy for 3 rounds
       Weakness potion: Makes your enemy take %80 more damage from your attacks

       All potion effects(other than poison) automatically apply
       
       Go back(1)");
       string aposifjpaodsifjposdij = Console.ReadLine();
   }
} while (gold > 0);
d12(sp, hp, dp, pp, wp);
 } static void d12(int sp0, int hp0, int dp0, int pp0, int wp0) {
     bool sp;
     bool hp;
     bool dp;
     int pp;
     bool ppact; 
     bool wp;

     
     int health = 100;
     int enemyhealth = 400;
     int dmg = 1;
     int g1 = 50;
     int g2 = 50;
     int g3 = 50;
     int g4 = 50;
     int user = 1;

     if (sp0 == 1) {sp = true;} else {sp = false;}
     if (hp0 == 1) {hp = true;} else {hp = false;}
     if (dp0 == 1) {dp = true;} else {dp = false;}
     if (wp0 == 1) {wp = true;} else {wp = false;}
     if (pp0 == 1) {pp = 3; ppact = false;} else {pp = 0; ppact = false;}

     if (sp == true && wp == true) { dmg = (20 + 20) + 32;} // total damage is 72(highest possible damage)
     if (sp == true && wp == false) { dmg = 20 + 20;} // total damage is 40
     if (sp == false && wp == true) { dmg = 20 + 16;}// total damage is 36
     if (sp == false && wp == false) { dmg = 20;}// total damage is 20

     Console.Clear();
     Console.WriteLine("You finished buying potions and left the hut");
     Thread.Sleep(2300);
     Console.Clear();
     Console.WriteLine(@"
___________________________________________________________________________________________________________________________________
|                                                                                                                                  |
|                                                                                                                                  |
|                                 /\                                                                                               |
|                                /  \                                                                                              |
|                               /    \                                                                                             |
|                              /      \                                                                                            |
|                             /        \                                                                                           |
|                            /          \                                                                                          |
|                           /|          |\                                                                                         |
|                            |   ____   |                                                                                          |
|                            |   |  |   |                                                                                          |
|                            |___|__|___|                                                                                          |
|                                |  |                                                                                              |
|                                 \  \                                                                                             |
|                                  \  \_____________________                                                                       |
|                                   |____________________  |                                                                       |      
|________________________________________________________|_|_______________________________________________________________________|

You where told by one of your knights that the rulers castle is up ahead
     ");
     Thread.Sleep(5000);
     Console.Clear();
     Console.WriteLine("You slowly walk forward with your sword and sheild in hand, and your new potions on your belt");
     Thread.Sleep(4000);
     Console.Clear();
     Console.WriteLine(@"
___________________________________________________________________________________________________________________________________
|                                    /             \                                                                               |
|                                   /               \                                                                              |
|                                  /  +           +  \                                                                             |
|                              /\  |                 |  /\                                                                         |
|                             /  \ |     _______     | /  \                                                                        |
|                             |  | |    |   |   |    | |  |                                                                        |
|                             |  | |    |   |   |    | |  |                                                                        |
|                             |__|_|____|___|___|____|_|__|                                                                        |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |      
|__________________________________________________________________________________________________________________________________|
     ");
     Thread.Sleep(5000);
     Console.Clear();
     Console.WriteLine("Before you enter the castle, you must know a couple of things. You can switch between controlling each indivisual gaurd(of which you have four) and using your personal attacks");
     Thread.Sleep(3000);
     Console.WriteLine("All potion effects are automattically applied to you(exept poison) You are the only one who can use these effects, your gaurds cannot");
     Thread.Sleep(4000);
     Console.Clear();
     Console.WriteLine("You walk into the castle and are greeted by the currnet king");
     Thread.Sleep(2300);
     Console.WriteLine("Oh I see, you have finaly come here");
     Thread.Sleep(2300);
     Console.WriteLine("It has been far too long since I had last seen you");
     Thread.Sleep(3000);
     Console.WriteLine("Well, you're nothing but a minor setback to my plan of ruling the world, so I will finally get rid of you! once and for all!");
     Thread.Sleep(4000);
     do {
     Console.Clear();
     if (user == 1) {
Console.WriteLine($@"
    ____________________________________________________
   |  hp({health}/100)         king hp({enemyhealth}/400)             |
   |                                                    |
   |           ___                                      |
   |          ('-')              (`-`)                  |
   |          --|--              --|--                  |   
   |            |                  |                    | 
   |___________/_\________________/_\___________________| 
   |                       Moves:                       |
   |          1.Attack     2.Switch Character           |              
   |___________________3.potion_info____________________| 
	");
string act = Console.ReadLine();
    if (act == "1") {
        Console.Clear();
        Console.WriteLine("You did " + dmg + " damage to the king!");
	if (ppact == true && pp > 0) 
	{
		pp--;
		Console.WriteLine("You also poisoned the king! dealing 30 damage " + pp + "Poison left");

		enemyhealth -= 30;
		if (pp < 0) {ppact = false;
		Console.WriteLine("You don't have any poison left");} 
		
	} 
        enemyhealth -= dmg;
        Thread.Sleep(3000);
        if (dp == true) {
          Console.Clear();
          Console.WriteLine("The king did 50 damage! but your potion helped you resist 20 damage! it dropped the total to 30 damage");
          health -= 30; 
	  Thread.Sleep(3000); 
        } else {
            Console.Clear();
            Console.WriteLine("The king did 50 damage to you!");
            health -= 50;
	    Thread.Sleep(3000);
        } 
        
        } else if (act == "2") {
            Console.Clear();
            Console.WriteLine(@$"
   ______________________________________________________
   |              Choose a character                    |
   |                                                    |
   |                                                    |
   |   1: Player             Health: {health}/100          |
   |                                                    |
   |   2: Knight 1           Health: {g1}/50            |   
   |                                                    | 
   |   3: Knight 2           Health: {g2}/50            |
   |                                                    | 
   |   4: Knight 3           Health: {g3}/50            | 
   |                                                    |
   |   5: Knight 4           Health: {g4}/50            | 
   |____________________________________________________| 
            ");
	    string act2 = Console.ReadLine();
	    if (act2 == "1") {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 1;
	    } else if (act2 == "2" && g1 > 0) {	 
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 2;
	    } else if (act2 == "2" && g1 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "3" && g2 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 3;
	    } else if (act2 == "3" && g2 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "4" && g3 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 4;
	    } else if (act2 == "4" && g3 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "5" && g4 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 5;
	    } else if (act2 == "5" && g4 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        }
    } else {
	Console.Clear();
        if (sp == true) {Console.WriteLine("You have a strength potion in use");}
        if (hp == true) {Console.WriteLine("You have a health potion in use");}
        if (dp == true) {Console.WriteLine("You have a defence potion in play");}
        if (wp == true) {Console.WriteLine("You have a weakness potion in play");}
	if (pp == 0) {
	Console.WriteLine("Go back(1)");
	string aspdoifjapsoidfjadpofijapsodifj = Console.ReadLine();

	
	} else {
		Console.WriteLine("You have a poison potion, do you want to activate it?[y/n]");}
		string ppq = Console.ReadLine();
		if (ppq == "y") {Console.Clear(); ppact = true; Console.WriteLine("Set poison potion to true, returning to batle"); Thread.Sleep(3000);} else {
		Console.WriteLine("Did not enable poison potion, returning to battle");}



        
    }


     } else if (user == 2) {
         Console.WriteLine($@"
    ____________________________________________________
   |  hp({g1}/50)         king hp({enemyhealth}/400)         |
   |                                                    |
   |                                                    |
   |          ('-')              (`-`)                  |
   |                             --|--                  |   
   |                               |                    | 
   |______________________________/_\___________________| 
   |                       Moves:                       |
   |          1.Attack     2.Switch Character           |              
   |___________________3.potion_info____________________| 
	");
string act = Console.ReadLine();
    if (act == "1") {
        Console.Clear();
        Console.WriteLine("You did 50 damage to the king!");
        enemyhealth -= 50;
        Thread.Sleep(3000);
        if (dp == true) {
          Console.Clear();
          Console.WriteLine("The king did 50 damage...");
          g1 -= 50; 
	  Thread.Sleep(3000); 
        } 
        
        } else if (act == "2") {
            Console.Clear();
            Console.WriteLine(@$"
   ______________________________________________________
   |              Choose a character                    |
   |                                                    |
   |                                                    |
   |   1: Player             Health: {health}/100          |
   |                                                    |
   |   2: Knight 1           Health: {g1}/50            |   
   |                                                    | 
   |   3: Knight 2           Health: {g2}/50            |
   |                                                    | 
   |   4: Knight 3           Health: {g3}/50            | 
   |                                                    |
   |   5: Knight 4           Health: {g4}/50            | 
   |____________________________________________________| 
            ");
	    string act2 = Console.ReadLine();
	    if (act2 == "1") {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 1;
	    } else if (act2 == "2" && g1 > 0) {	 
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 2;
	    } else if (act2 == "2" && g1 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "3" && g2 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 3;
	    } else if (act2 == "3" && g2 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "4" && g3 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 4;
	    } else if (act2 == "4" && g3 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "5" && g4 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 5;
	    } else if (act2 == "5" && g4 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        }
    } else {
	Console.Clear();
        if (sp == true) {Console.WriteLine("You have a strength potion in use");}
        if (hp == true) {Console.WriteLine("You have a health potion in use");}
        if (dp == true) {Console.WriteLine("You have a defence potion in play");}
        if (wp == true) {Console.WriteLine("You have a weakness potion in play");}
     }
     
    
        
     } else if (user == 3) {
         Console.WriteLine($@"
    ____________________________________________________
   |  hp({g2}/50)         king hp({enemyhealth}/400)         |
   |                                                    |
   |                                                    |
   |          ('-')              (`-`)                  |
   |                             --|--                  |   
   |                               |                    | 
   |______________________________/_\___________________| 
   |                       Moves:                       |
   |          1.Attack     2.Switch Character           |              
   |___________________3.potion_info____________________| 
	");
string act = Console.ReadLine();
    if (act == "1") {
        Console.Clear();
        Console.WriteLine("You did 50 damage to the king!");
        enemyhealth -= 50;
        Thread.Sleep(3000);
        if (dp == true) {
          Console.Clear();
          Console.WriteLine("The king did 50 damage...");
          g2 -= 50; 
	  Thread.Sleep(3000); 
        } 
        
        } else if (act == "2") {
            Console.Clear();
            Console.WriteLine(@$"
   ______________________________________________________
   |              Choose a character                    |
   |                                                    |
   |                                                    |
   |   1: Player             Health: {health}/100          |
   |                                                    |
   |   2: Knight 1           Health: {g1}/50            |   
   |                                                    | 
   |   3: Knight 2           Health: {g2}/50            |
   |                                                    | 
   |   4: Knight 3           Health: {g3}/50            | 
   |                                                    |
   |   5: Knight 4           Health: {g4}/50            | 
   |____________________________________________________| 
            ");
	    string act2 = Console.ReadLine();
	    if (act2 == "1") {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 1;
	    } else if (act2 == "2" && g1 > 0) {	 
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 2;
	    } else if (act2 == "2" && g1 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "3" && g2 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 3;
	    } else if (act2 == "3" && g2 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "4" && g3 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 4;
	    } else if (act2 == "4" && g3 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "5" && g4 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 5;
	    } else if (act2 == "5" && g4 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        }
    } else {
	Console.Clear();
        if (sp == true) {Console.WriteLine("You have a strength potion in use");}
        if (hp == true) {Console.WriteLine("You have a health potion in use");}
        if (dp == true) {Console.WriteLine("You have a defence potion in play");}
        if (wp == true) {Console.WriteLine("You have a weakness potion in play");}
     }
     
    
        
     } else if (user == 4) {
            Console.WriteLine($@"
    ____________________________________________________
   |  hp({g3}/50)         king hp({enemyhealth}/400)         |
   |                                                    |
   |                                                    |
   |          ('-')              (`-`)                  |
   |                             --|--                  |   
   |                               |                    | 
   |______________________________/_\___________________| 
   |                       Moves:                       |
   |          1.Attack     2.Switch Character           |              
   |___________________3.potion_info____________________| 
	");
string act = Console.ReadLine();
    if (act == "1") {
        Console.Clear();
        Console.WriteLine("You did 50 damage to the king!");
        enemyhealth -= 50;
        Thread.Sleep(3000);
        if (dp == true) {
          Console.Clear();
          Console.WriteLine("The king did 50 damage...");
          g3 -= 50; 
	  Thread.Sleep(3000); 
        } 
        
        } else if (act == "2") {
            Console.Clear();
            Console.WriteLine(@$"
   ______________________________________________________
   |              Choose a character                    |
   |                                                    |
   |                                                    |
   |   1: Player             Health: {health}/100          |
   |                                                    |
   |   2: Knight 1           Health: {g1}/50            |   
   |                                                    | 
   |   3: Knight 2           Health: {g2}/50            |
   |                                                    | 
   |   4: Knight 3           Health: {g3}/50            | 
   |                                                    |
   |   5: Knight 4           Health: {g4}/50            | 
   |____________________________________________________| 
            ");
	    string act2 = Console.ReadLine();
	    if (act2 == "1") {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 1;
	    } else if (act2 == "2" && g1 > 0) {	 
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 2;
	    } else if (act2 == "2" && g1 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "3" && g2 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 3;
	    } else if (act2 == "3" && g2 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "4" && g3 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 4;
	    } else if (act2 == "4" && g3 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "5" && g4 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 5;
	    } else if (act2 == "5" && g4 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        }
    } else {
	Console.Clear();
        if (sp == true) {Console.WriteLine("You have a strength potion in use");}
        if (hp == true) {Console.WriteLine("You have a health potion in use");}
        if (dp == true) {Console.WriteLine("You have a defence potion in play");}
        if (wp == true) {Console.WriteLine("You have a weakness potion in play");}
     }
     } else if (user == 5){
            Console.WriteLine($@"
    ____________________________________________________
   |  hp({g4}/50)         king hp({enemyhealth}/400)         |
   |                                                    |
   |                                                    |
   |          ('-')              (`-`)                  |
   |                             --|--                  |   
   |                               |                    | 
   |______________________________/_\___________________| 
   |                       Moves:                       |
   |          1.Attack     2.Switch Character           |              
   |___________________3.potion_info____________________| 
	");
string act = Console.ReadLine();
    if (act == "1") {
        Console.Clear();
        Console.WriteLine("You did 50 damage to the king!");
        enemyhealth -= 50;
        Thread.Sleep(3000);
        if (dp == true) {
          Console.Clear();
          Console.WriteLine("The king did 50 damage...");
          g4 -= 50; 
	  Thread.Sleep(3000); 
        } 
        
        } else if (act == "2") {
            Console.Clear();
            Console.WriteLine(@$"
   ______________________________________________________
   |              Choose a character                    |
   |                                                    |
   |                                                    |
   |   1: Player             Health: {health}/100          |
   |                                                    |
   |   2: Knight 1           Health: {g1}/50            |   
   |                                                    | 
   |   3: Knight 2           Health: {g2}/50            |
   |                                                    | 
   |   4: Knight 3           Health: {g3}/50            | 
   |                                                    |
   |   5: Knight 4           Health: {g4}/50            | 
   |____________________________________________________| 
            ");
	    string act2 = Console.ReadLine();
	    if (act2 == "1") {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 1;
	    } else if (act2 == "2" && g1 > 0) {	 
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 2;
	    } else if (act2 == "2" && g1 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "3" && g2 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 3;
	    } else if (act2 == "3" && g2 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "4" && g3 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 4;
	    } else if (act2 == "4" && g3 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        } else if (act2 == "5" && g4 > 0) {
	    Console.Clear();    
	    Console.WriteLine("Changing character...");
	    Thread.Sleep(2300);
	    user = 5;
	    } else if (act2 == "5" && g4 == 0) {
        Console.Clear();    
        Console.WriteLine("He's dead...");
        Thread.Sleep(2000);    
        }
    } else {
	Console.Clear();
        if (sp == true) {Console.WriteLine("You have a strength potion in use");}
        if (hp == true) {Console.WriteLine("You have a health potion in use");}
        if (dp == true) {Console.WriteLine("You have a defence potion in play");}
        if (wp == true) {Console.WriteLine("You have a weakness potion in play");}
     }
     }
     if (user == 2 && g1 == 0) {Console.WriteLine("Your active character died!");
     Console.WriteLine("Changing character..."); 
     Thread.Sleep(2300);
     user = 1;}
     if (user == 3 && g2 == 0) {Console.WriteLine("Your active character died!");
     Console.WriteLine("Changing character..."); 
     Thread.Sleep(2300);
     user = 1;}
     if (user == 4 && g3 == 0) {Console.WriteLine("Your active character died!");
     Console.WriteLine("Changing character..."); 
     Thread.Sleep(2300);
     user = 1;} 
     if (user == 5 && g4 == 0) {Console.WriteLine("Your active character died!");
     Console.WriteLine("Changing character..."); 
     Thread.Sleep(2300);
     user = 1;} 
         
     } while (health > 0 && enemyhealth > 0);
     if (health <= 0) {
         Console.Clear();
         Console.WriteLine(@$"
 __     __               _ _          _       
 \ \   / /              | (_)        | |      
  \ \_/ /__  _   _    __| |_  ___  __| |      
   \   / _ \| | | |  / _` | |/ _ \/ _` |      
    | | (_) | |_| | | (_| | |  __/ (_| |_ _ _ 
    |_|\___/ \__,_|  \__,_|_|\___|\__,_(_|_|_)

    Imagine dying 

    Try Again(1)

         ");
         string apoifjapsoidfjapoisdjfpaosijdfpaoisjdfpaosidjf = Console.ReadLine();
         d11();
     } else if (enemyhealth <= 0 ) {
         Finale();
     }
     } static void Finale() {

     }
 } 
   }
}
  

