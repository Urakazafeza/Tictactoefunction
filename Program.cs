
using System;

using System.Threading;
 

namespace TIC_TAC_TOE
{ class Program

    { 
        static char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1;   

        static int choice;    

        static int flag = 0;
        static void Main(string[] args)

        {
            do

            {
                Console.Clear(); 

                Console.WriteLine("Player1:X and Player2:O");

                Console.WriteLine("\n");

                if (player % 2 == 0)

                {
                    Console.WriteLine("Player 2 Chance");
                }

                else
                {
                    Console.WriteLine("Player 1 Chance");
                }

                Console.WriteLine("\n");

                Board();  

                choice = int.Parse(Console.ReadLine());  

                if (array[choice] != 'X' && array[choice] != 'O')

                {
                    if (player % 2 == 0)   

                    {
                        array[choice] = 'O';
                        player++;
                    }

                    else
                    {
                        array[choice] = 'X';
                        player++;
                    }

                }

                else 
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, array[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(1000);

                }

                flag = CheckWin();  

            } while (flag != 1 && flag != -1);
            Console.Clear();  

            Board();  
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }

            else  

            {

                Console.WriteLine("Draw");

            }

            Console.ReadLine();

        }

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);

            Console.WriteLine("     |     |      ");

        }

        private static int CheckWin()

        {

            #region Horizontal Winning Condition
  

            if (array[1] == array[2] && array[2] == array[3])

            {

                return 1;

            }
  

            else if (array[4] == array[5] && array[5] == array[6])

            {

                return 1;

            }

            else if (array[6] == array[7] && array[7] == array[8])

            {

                return 1;

            }

            #endregion

            #region vertical Winning Condition     

            else if (array[1] == array[4] && array[4] == array[7])

            {

                return 1;

            }

            else if (array[2] == array[5] && array[5] == array[8])

            {
                return 1;}

            else if (array[3] == array[6] && array[6] == array[9])

            {
                return 1;}

            #endregion

            #region Diagonal Winning Condition

            else if (array[1] == array[5] && array[5] == array[9])

            {
                return 1;
            }
            else if (array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }

            #endregion
            #region Checking For Draw

            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')

            { return -1; }

            #endregion

            else

            {

                return 0;

            }

        }

    }

}