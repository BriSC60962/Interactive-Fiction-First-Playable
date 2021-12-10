using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction_First_Playable
{
    class Program
    {
        static int pageNumber = 0; //Text within the elements
        static string[] readLines; //Number of lines used in .txt
        static bool active = true; //Runs Gameplay
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please input your selection by typing the following keys: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("N = New Game");
            Console.WriteLine("L = Load Game");
            Console.WriteLine("Q = Quit Game");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            ConsoleKeyInfo playerInput = Console.ReadKey(true);
         
            if (playerInput.Key == ConsoleKey.N) //New Game
            {
                pageNumber = 0;
            }
            else if (playerInput.Key == ConsoleKey.L) //Load Game
            {
                LoadGame();
            }
            else if (playerInput.Key == ConsoleKey.Q) //Quit Game
            {
                active = false;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input: Enter designated keys to select a path option.");
                Console.ForegroundColor = ConsoleColor.Gray;
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
            ConsoleKeyInfo playerInput = Console.ReadKey(true); //Reads the keypress and directs to selected page
            if (playerInput.Key == ConsoleKey.A)
            {
                pageNumber = Convert.ToInt32(result[3]);
            }

            else if (playerInput.Key == ConsoleKey.B)
            {
                pageNumber = Convert.ToInt32(result[4]);
            }
            else if (playerInput.Key == ConsoleKey.S)
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
            for (int b = 0; b < readLines.Length; b++)
            {
                if (String.IsNullOrWhiteSpace(readLines[b]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: story.txt file contains blanks");
                    Console.ReadKey(true);
                    MainMenu();
                    Console.WriteLine();
                    GameRun();
                }

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
                for (int b = 0; b < 14; b++)
                {
                    if (String.IsNullOrWhiteSpace(readLines[b]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: story.txt file contains blanks");
                        Console.ReadKey(true);
                        MainMenu();
                        Console.WriteLine();
                        GameRun();
                    }
                    else
                    {

                    }
                }
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.Write("Please input your selection by typing the following keys: ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" A = " + result[1]);
                    Console.WriteLine(" B = " + result[2]);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    KeyInput();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        } 
    }
}
