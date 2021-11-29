using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction_First_Playable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;

            

            char[] charSeparators = new char[] { ';' }; //character separator used to use appropriate elements in the story array
            string[] result; // String Name of elements in the Array
            int pageNumber = 0;

            string[] readLines;
            readLines = System.IO.File.ReadAllLines(@"story.txt");
            Console.WriteLine(readLines[0]);
            Console.WriteLine(readLines[1]);
            Console.ReadKey(true);

            //while (active == true)
            //{
            //    result = story[pageNumber].Split(charSeparators, StringSplitOptions.None);
            //    Console.WriteLine(result[0]);
            //    Console.ReadKey(true);

            //    if (result[1] == "End") //Checks for Story Ending Page
            //    {
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("THE END");
            //        active = false;
            //    }
            //    else if (result[1] == "") //Checks for empty element
            //    {
            //        Console.WriteLine();
            //        pageNumber = Convert.ToInt32(result[3]);
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Cyan;       
            //        Console.WriteLine();
            //        Console.WriteLine(" A: " + result[1]);
            //        Console.WriteLine(" B: " + result[2]);
            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.Write("Please input your selection by typing the \"A\" or \"B\" keys hit the \"Enter\" key...");
            //        Console.WriteLine();
            //        Console.WriteLine();
            //        Console.Write("Key Input: ");
            //        Console.ForegroundColor = ConsoleColor.Gray;

            //        string playerInput = Console.ReadLine().ToString(); //Reads the keypress and directs to selected page
            //        if (playerInput == "a" || playerInput == "A")
            //        {
            //            pageNumber = Convert.ToInt32(result[3]);
            //        }

            //        else if (playerInput == "b" || playerInput == "B")
            //        {
            //            pageNumber = Convert.ToInt32(result[4]);
            //        }

            //        Console.WriteLine();
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
        }
        //"Interactive Fiction - First Playable\nBy: Brianna Chisholm\nLogic and Programming I\nNovember 26th 2021;;;1;;", 
        //     " Page 1\n\n Walking in the woods to get to a friends house one day, you\n stumble upon a small wooden doll. The doll gives off an\n unsettling aura, you contemplate taking the doll with you.; Take the doll?; Leave the doll.;2;3;",
        //     " Page 2\n\n You pick up the doll and start to proceed through the woods, but the doll\n starts to tuck on your shirt pointing in another direction. It seemed\n desperate so you follow its directions without thinking, trusting its\n protecting you from something ahead. Suddenly you come to a fork in \n the road, the doll points to one direction but you can't help but \n feel uneasy.;Trust the doll.;ignore the doll.;4;5;",
        //     " Page 3\n\n You leave the doll and proceed on your path, but you can't help but\n feel watched as you leave. As you walk you come across an old women\n in dark and tattered clothes, She asks you, \"Have you seen a small\n wooden doll running around here? I've been looking everywhere for\n it.\" you think of the doll you passed by but it wasn't running\n around, perhaps its the one she looking for?;Inform her about the doll.;Say you didn't see the doll.;6;7;",
        //     " Page 4\n\n You follow the doll and approach a strange hut filled with wooden dolls\n caged and bound up, upon noticing you enter they all break into chaos\n trying to get your attention to release them. You ponder if there is a\n valid reason for their imprisonment.;Release the dolls.;Refuse to help.;8;9;",
        //     " Page 5\n\n You make for the other path and the doll leaps out of your pocket and\n leaves for the other direction, while you are a mite curious to know\n the purpose for the living wooden doll in the woods, you carry on your\n path. Starting to feel slightly lost a couple options come to mind.\n Turn around for home before you get totally lost or carry on in the\n hopes of reaching your destination?;Turn around.;Keep going.;10;11;",
        //     " Page 6\n\n The women thanks you for the help and leaves to gather her doll,\n but not before gifting you a small wooden neckless with a\n crystal charm.;Keep the charm;Ditch the charm and carry on;12;11;", 
        //     " Page 7\n\n You claim you've seen nothing of the sort. The woman yells out\n in an unknown language, latching onto your hand, you pull away\n and run further into the woods. Looking at your hand you start\n to realize its different from before... it's turning into\n wood... and spreading fast! If this keeps up you could find\n yourself in a rough situation, panicking you can only think\n of one solution...;Chop off your hand.;Suffer the consequences.;13;14;",
        //    " You release the dolls and they all scatter into the woods, you reach\n into your pocket for the doll but its no longer with you, instead\n there is a note, it simply reads \"Thank You.\";End;;;;",
        //    " You shake your head and turn to leave, the doll in your pocket leaps out\n to free the others. You can't help but hesitate and watch the dolls escape\n in droves, in mere moments they all crowd around you. As you back away and\n turn you trip over one of the dolls into a boiling cauldron face first,\n the searing liquid drenches your face. You fall to the floor, you cannot\n see, you cannot see! YOU CANNOT SEE! Your face feels different, your face\n feels stiff, your face feels... Wooden...;End;;;;",
        //    " You give up and head back still believing you know your way around,\n and you are able to get back to your lovely home, however you feel\n you missed out on some kind of adventure, but you feel safe.;End;;;;",
        //    " Going forward you start to feel more and more lost, you don't even\n feel like you know how to get back home anymore, you feel like you\n are just going in circles, you travel like this for hours... days...\n weeks even, \"what is up with these woods? Why can't I leave!?\"\n Years pass, yet you do not starve. You are trapped, no longer\n remembering who you are and why you're here, you've gone insane\n long ago... An image comes to mind, possibly the only clear image\n you can recall that isn't an endless path of trees... a small\n wooden doll... laying in the woods.;End;;;;",
        //    " You feel safe with this charm as if it provides you with clarity\n of mind, and you proceeds through the thickets of the woods as if\n its nothing. Making it to your friends timely and safely.;End;;;;",
        //    " The very thought of chopping your hand off terrifies you,\n but not as much as turning into a TREE! You slice it off,\n and bolt out off the woods. You manage to avoid the curse\n but at the cost of losing a piece of yourself.;End;;;;",
        //    " You watch in a helpless panic, you can't stop the curse from\n spreading. Your arm... Your legs... Your neck, all slowly\n transforming into wood, no longer can you move them.\n Eventually you no longer represent the human you once\n were and become a tree among hundreds of others, and those\n who pass by would never know the difference...;End;;;;"};

}
    }


