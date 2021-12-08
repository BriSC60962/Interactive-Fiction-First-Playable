using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction_First_Playable
{
    class Program
    {
        static int pageNumber = 0;
        static string[] readLines;
        static bool active = true;
        static string[] result; 
        static void Main(string[] args)
        {
            MainMenu();
            Console.WriteLine();
            GameRun();
        }
        static void MainMenu() // Displays Title, Creator, Course, Date, and Main Menu Options
        {
            Console.WriteLine("The Doll in the Woods");
            Console.WriteLine("By: Brianna Chisholm");
            Console.WriteLine("Logic and Programming I");
            Console.WriteLine("December 10th, 2021");
            Console.WriteLine();
            Console.WriteLine("Press the \"N\",\"L\", or \"Q\" keys to select: ");
            Console.WriteLine();
            Console.WriteLine("New Game");
            Console.WriteLine("Load Game");
            Console.WriteLine("Quit Game");
            Console.WriteLine();
            Console.Write("Key Input: ");
            string playerInput = Console.ReadLine().ToString();
         
            if (playerInput == "n" || playerInput == "N") //New Game
            {
                pageNumber = 0;
            }
            else if (playerInput == "l" || playerInput == "L") //Load Game
            {
                LoadGame();
            }
            else if (playerInput == "q" || playerInput == "Q") //Quit Game
            {
                active = false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input: Enter designated keys to select a path option.");
                Console.WriteLine();
                MainMenu();
            }
        }
        static void LoadGame() //Reads from the savegame.txt file to continue game progress
        {
            string loadLines = System.IO.File.ReadAllText(@"savegame.txt");
            pageNumber = Convert.ToInt32(loadLines);
            Console.WriteLine();
        }
        static void SaveGame() //Writes current page to a savegame.txt file
        {
            Console.WriteLine("Game has been Saved");
            string savefile = pageNumber.ToString();
            System.IO.File.WriteAllText("savegame.txt", savefile);
        }
        static void KeyInput() //Reads key input and directs player to new page
        {
            string playerInput = Console.ReadLine().ToString(); //Reads the keypress and directs to selected page
            if (playerInput == "a" || playerInput == "A")
            {
                pageNumber = Convert.ToInt32(result[3]);
            }

            else if (playerInput == "b" || playerInput == "B")
            {
                pageNumber = Convert.ToInt32(result[4]);
            }
            else if (playerInput == "s" || playerInput == "S")
            {
                SaveGame();
            }
        }
        static void GameRun() //Runs the while loop and "runs" the game
        {
            char[] charSeparators = new char[] { ';' }; 
            readLines = System.IO.File.ReadAllLines(@"story.txt");
            if (readLines.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: story.txt is Empty");
                Console.ReadKey(true);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                MainMenu();
                Console.WriteLine();
                GameRun();
            }
            else if (String.IsNullOrWhiteSpace(readLines[0]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: story.txt file contains blanks");
                Console.ReadKey(true);
                MainMenu();
                Console.WriteLine();
                GameRun();
            }



            if (readLines.Length < 14)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: story.txt length is lower than expected");
                Console.ReadKey(true);
                MainMenu();
                Console.WriteLine();
                GameRun();
            }

            else if (readLines.Length > 14)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: story.txt length is higher than expected");
                Console.ReadKey(true);
                MainMenu();
                Console.WriteLine();
                GameRun();
            }

            while (active == true)
            {
                result = readLines[pageNumber].Split(charSeparators, StringSplitOptions.None);
                Console.WriteLine(result[0]);
                Console.ReadKey(true);

                if (result[1] == "End") //Checks for Story Ending Page
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("THE END");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.ReadKey(true);
                    MainMenu();
                    Console.WriteLine();
                    GameRun();
                }
                else if (result[1] == "") //Checks for empty element
                {
                    Console.WriteLine();
                    pageNumber = Convert.ToInt32(result[3]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine(" A: " + result[1]);
                    Console.WriteLine(" B: " + result[2]);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Please input your selection by typing the \"A\" or \"B\" keys hit the \"Enter\" key...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Key Input: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    KeyInput();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        } 
    }
}
