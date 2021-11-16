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
            {"Interactive Fiction - First Playable\nBy: Brianna Chisholm\nLogic and Programming I\nNovember 26th 2021;;;1;2;",
             "Options1;A;B;3;4;",
             "Options2;A;B;5;6;",
             "Options3;A;B;7;8;",
             "Options4;A;B;9;10;",
             "Options5;A;B;11;12;",
             "Options6;A;B;13;14;",
             "Options7;A;B;15;16;",
            "End1;1;;;;",
            "End2;1;;;;",
            "End3;1;;;;",
            "End4;1;;;;",
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
                    Console.Write(result[1]);
                    Console.Write(" or ");
                    Console.Write(result[2]);
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
 
