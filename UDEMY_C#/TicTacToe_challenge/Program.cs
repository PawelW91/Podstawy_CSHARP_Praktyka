// My idea to solve TicTacToe challenge in Udemy C# Masterclass
// Players take turns to play fields from 1 to 9, if Player input invalid data, he will be asked to choose again.
// Once you have selected a winner, the game will ask you to reset or exit.
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] ttt = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            string x, y;
            int counter = 0, exit,turns=0;
            ConsoleKeyInfo keyInfo;
            do
            {
                counter = 0;
                Reset(ttt);
                do
                {
                    Console.Clear();
                    Board(ttt);
                    if (counter % 2 == 0)
                    {
                        Console.WriteLine("Player 1: Choose your field!");
                        x = Console.ReadLine();
                        bool correctInput = false;
                        while (!correctInput)
                        {
                            for (int i = 0; i < ttt.GetLength(0); i++)
                            {
                                for (int j = 0; j < ttt.GetLength(1); j++)
                                {
                                    if (ttt[i, j].Equals(x))
                                    {
                                        ttt[i, j] = "O";
                                        correctInput = true;
                                        break;
                                    }
                                }
                                if (correctInput) break;
                            }
                            if (!correctInput)
                            {
                                Console.WriteLine(" Incorrect input! Please try another field!");
                                y = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player 2: Choose your field!");
                        y = Console.ReadLine();
                        bool correctInput = false;
                        while (!correctInput)
                        {
                            for (int i = 0; i < ttt.GetLength(0); i++)
                            {
                                for (int j = 0; j < ttt.GetLength(1); j++)
                                {
                                    if (ttt[i, j].Equals(y))
                                    {
                                        ttt[i, j] = "X";
                                        correctInput = true;
                                        break;
                                    }
                                }
                                if (correctInput) break;
                            }
                            if (!correctInput)
                            {
                                Console.WriteLine(" Incorrect input! Please try another field!");
                                y = Console.ReadLine();
                            }
                        }

                    }
                    counter++;
                    turns++;
                    if (turns == 9)
                    {
                        Console.WriteLine("Draw!");
                        Console.WriteLine("Press any key to reset!");
                        Console.WriteLine("Press 0 to EXIT");
                        keyInfo = Console.ReadKey();
                        exit = keyInfo.KeyChar - '0';
                        if (exit == 0) { Environment.Exit(0); }
                        else { Reset(ttt); }
                    }

                } while (!Checker(ttt));
                Console.Clear();
                Board(ttt);
                if (counter % 2 == 1) { Console.WriteLine("Winner is Player 1!"); }
                else { Console.WriteLine("Winner is Player 2!"); }
                Console.WriteLine();
                Console.WriteLine("Press any key to reset!");
                Console.WriteLine("Press 0 to EXIT");
                keyInfo = Console.ReadKey();
                exit = keyInfo.KeyChar - '0';
                
            } while (exit != 0);
        }

            public static bool Checker(string[,] board)
        {
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2] ||
                board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2] ||
                board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2] ||
                board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0] ||
                board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1] ||
                board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2] ||
                board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] ||
                board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            { return true; }
            else return false;
        }
        public static void Board(string[,] ttt)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {ttt[0, 0]}  |  {ttt[0, 1]}  |  {ttt[0, 2]}  ");
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {ttt[1, 0]}  |  {ttt[1, 1]}  |  {ttt[1, 2]}  ");
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {ttt[2, 0]}  |  {ttt[2, 1]}  |  {ttt[2, 2]}  ");
            Console.WriteLine("     |     |     ");
        }
        public static void Reset(string[,] ttt)
        {
            int z = 0;
            for (int i = 0; i < ttt.GetLength(0); i++)
            {
                for (int j = 0; j < ttt.GetLength(1); j++)
                {
                    ttt[i, j] = z.ToString();
                    z++;
                }
            }
        }
    }
}
