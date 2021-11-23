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

            string[] story = new string[]
            {"Interactive Fiction - First Playable\nBy: Brianna Chisholm\nLogic and Programming I\nNovember 26th 2021;;;1;;", 
             " Page 1\n\n Walking in the woods to get to a friends house one day, you stumble upon a small wooden doll.\n The doll gives off an unsettling aura, you contemplate taking the\n doll with you. Should you take the doll?;A;B;2;3;",
             " Page 2\n\n You pick up the doll and start to proceed through the woods, but the doll\n starts to tuck on your shirt pointing in another direction. It seemed\n desperate so you follow its directions without thinking, trusting its\n protecting you from something ahead. Suddenly you come to a fork in \n the road, the doll points to one direction but you can't help but \n feel uneasy. Trust the doll?;A;B;4;5;",
             " Page 3\n\n You leave the doll and proceed on your path, but you can't help but\n feel watched as you leave. As you walk you come across an old women\n in dark and tattered clothes, She asks you, \"Have you seen a small\n wooden doll running around here? I've been looking everywhere for\n it.\" you think of the doll you passed by but it wasn't running\n around, perhaps its the one she looking for? Inform her of the doll?;A;B;6;7;",
             " Page 4\n\n You follow the doll and approach a strange hut filled with wooden dolls\n caged and bound up, upon noticing you enter they all break into chaos\n trying to get your attention to release them. You ponder if there is a\n valid reason for their imprisonment. Release the wooden dolls?;A;B;8;9;",
             " Page 5\n\n You make for the other path and the doll leaps out of your pocket and leaves for the other direction, while you are a mite curious to know the purpose for the living wooden doll in the woods, you carry on your path. Starting to feel slightly lost a couple options come to mind. Turn around for home before you get totally lost or carry on in the hopes of reaching your destination? Turn around?;A;B;10;11;",
             " Page 6\n\n ;A;B;12;13;", // changes A and B to be your options   "do this;do that"
             " Page 7\n\n;A;B;14;15;",
            " You release the dolls and they all scatter into the woods, you reach\n into your pocket for the doll but its no longer with you, instead\n there is a note, it simply reads \"Thank You.\";End;;;;",
            " You shake your head and turn to leave, the doll in your pocket leaps out\n to free the others. You can't help but hesitate and watch the dolls escape\n in droves, in mere moments they all crowd around you. As you back away and\n turn you trip over one of the dolls into a boiling cauldron face first,\n the searing liquid drenches your face. You fall to the floor, you cannot\n see, you cannot see! YOU CANNOT SEE! Your face feels different, your face\n feels stiff, your face feels... Wooden...;End;;;;",
            " You give up and head back still believing you know your way around, and you are able to get back to your lovely home, however you feel you missed out on some kind of adventure, but you feel safe.;End;;;;",
            " Going forward you start to feel more and more lost, you don't even feel like you know how to get back home anymore, you feel like you are just going in circles, you travel like this for hours... days... weeks even, \"what is up with these woods? Why can't I leave!?\" Years pass, yet you do not starve. You are trapped, no longer remembering who you are and why you're here, you've gone insane long ago... An image comes to mind, possibly the only clear image you can recall that isn't an endless path of trees... a small wooden doll... laying in the woods.;End;;;;",
            "End5;End;;;;",
            "End6;End;;;;",
            "End7;End;;;;",
            "End8;End;;;;"};

            char[] charSeparators = new char[] { ';' };
            string[] result;
            int pageNumber = 0;

            while (active == true)
            {
                result = story[pageNumber].Split(charSeparators, StringSplitOptions.None);
                Console.WriteLine(result[0]);
                Console.ReadKey(true);
                if (result[1] == "End")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("THE END");
                    active = false;
                }
                else if (result[1] == "A")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("A: Yes    B: No");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Please input your selection by typing ");
                    Console.Write("\"" + result[1] + "\"");
                    Console.Write(" or ");
                    Console.Write("\"" + result[2] + "\"");
                    Console.Write(" and hit the \"Enter\" key...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Key Input: ");
                    string playerInput = Console.ReadLine().ToString();
                    if (playerInput == "a")
                    {

                        pageNumber = Convert.ToInt32(result[3]);
                    }
                    else if (playerInput == "A")
                    {

                        pageNumber = Convert.ToInt32(result[3]);
                    }
                    else if (playerInput == "b")
                    {

                        pageNumber = Convert.ToInt32(result[4]);

                    }
                    else if (playerInput == "B")
                    {

                        pageNumber = Convert.ToInt32(result[4]);

                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    pageNumber = Convert.ToInt32(result[3]);
                }
            }
            Console.ReadKey(true);
        }
    }
}

