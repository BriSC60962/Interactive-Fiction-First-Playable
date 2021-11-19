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
             " Page 1\n\n Walking in the woods one day, you stumble upon a small wooden doll.\n The doll gives off an unsettling aura, you contemplate taking the\n doll with you. Should you take the doll?\n\n A: Yes    B: No;A;B;2;3;",
             " Page 2\n\n You pick up the doll and start to proceed through the woods, but the doll\n starts to tuck on your shirt pointing in another direction. It seemed\n desperate so you follow its directions without thinking, trusting its\n protecting you from something ahead. Suddenly you come to a fork in \n the road, the doll points to one direction but you can't help but \n feel uneasy. Trust the doll?\n\n A: Yes    B: No;A;B;4;5;",
             " Page 3\n\n You leave the doll and proceed on your path, but you feel watched\n as you leave. As you walk you come across an old women in dark and\n tattered clothes, She asks you, \"have you seen a small wooden doll\n running around here? I've been looking everywhere for it.\"\n you think of the doll you passed by but it wasn't running around,\n perhaps its the one she looking for? Inform her of the doll?\n\n A: Yes    B: No;A;B;6;7;",
             " Page 4\n\nred apple? trail of candy?;A;B;8;9;",
             " Page 5\n\nbear tracks? torn red hood?;A;B;10;11;",
             " Page 6\n\n;A;B;12;13;",
             " Page 7\n\n;A;B;14;15;",
            "apple end;1;;;;",
            "candy end;1;;;;",
            "bear end;1;;;;",
            "red end;1;;;;",
            "End5;1;;;;",
            "End6;1;;;;",
            "End7;1;;;;",
            "End8;1;;;;"};

            char[] charSeparators = new char[] { ';' };
            string[] result;
            int pageNumber = 0;

            while (active == true)
            {
                result = story[pageNumber].Split(charSeparators, StringSplitOptions.None);
                Console.WriteLine(result[0]);
                Console.ReadKey(true);
                if (result[1] == "1")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("THE END");
                    active = false;
                }
                else if (result[1] == "A")
                {
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

