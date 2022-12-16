using System;
namespace homework
{
    public class TicTacToe
    {

        int[,] field =
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0},
        };

        static bool win;
        int player = 1;
        int row = 0;
        int col = 0;

        public TicTacToe()
        {

        }

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Game Started");

            TicTacToe initGame = new TicTacToe();

            int counter = 0;

            while(counter < 9)
            {
                initGame.PrintField();
                initGame.GetRowAndCol();
                initGame.SetValue();
                win = initGame.CheckWin();

                if (win)
                {
                    break;
                }

                initGame.ChangePlayer();

                counter++;
            }

            initGame.PrintField();
            initGame.PrintResult();
        }

        void PrintField()
        {
            Console.WriteLine();
            Console.WriteLine("Player: " + player);
            Console.WriteLine("----------------------------");

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] == 1)
                    {
                        Console.Write("X\t");
                    }

                    else if (field[i, j] == 10)
                    {
                        Console.Write("O\t");
                    }

                    else
                    {
                        Console.Write("_\t");
                    }
                }
                Console.WriteLine();
            }
        }


        void GetRowAndCol()
        {
            do
            {
                do
                {
                    Console.Write("Enter a row in range:[1..3]");
                    string Rowstr = Console.ReadLine();
                    try
                    {
                        row = Convert.ToInt32(Rowstr);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                } while (row > 3 || row < 1);

                do
                {
                    Console.Write("Enter a column in range:[1..3]");
                    string Colstr = Console.ReadLine();
                    try
                    {
                        col = Convert.ToInt32(Colstr);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input.");
                    }

                } while (col > 3 || col < 1);
                row--;
                col--;
            } while (field[row, col] != 0);
        }


        void SetValue()
        {
            if (player == 1)
            {
                field[row, col] = 1;
            }
            else
            {
                field[row, col] = 10;
            }
        }

        bool CheckWin()
        {
            int sum = 0;

            //iteration through rows
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += field[i, j];
                }

                if (sum == 3 || sum == 30)
                {
                    return true;
                }

                sum = 0;
            }

            //iteration through columns
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += field[j, i];
                }

                if (sum == 3 || sum == 30)
                {
                    return true;
                }

                sum = 0;
            }

            //iteration through major diagonal
            sum = field[1, 1] + field[2, 2] + field[0, 0];

            if (sum == 3 || sum == 30)
            {
                return true;
            }

            //iteration through sub diagonal
            sum = field[0, 2] + field[1, 1] + field[2, 0];

            if (sum == 3 || sum == 30)
            {
                return true;
            }

            return false;
        }

        void ChangePlayer()
        {
            if (player == 1)
            {
                player = 2;
            }
            else
            {
                player = 1;
            }
        }

        void PrintResult()
        {
            if (win)
            {
                if (player == 1)
                {
                    Console.WriteLine("First player won the game!");
                }
                else
                {
                    Console.WriteLine("Second player won the game!");
                }
            }

            else
            {
                Console.WriteLine("Draw!");
            }

            Restart();
        }

        void Restart()
        {
            Console.WriteLine("Play again?");
            Console.WriteLine("1 - yes");
            Console.WriteLine("0 - no");

            string val = Console.ReadLine();

            switch(val)
            {
                case "1":
                    {
                        Start();
                        break;
                    }
                case "0":
                    {
                        return;
                    }
            }
        }
    }
}

