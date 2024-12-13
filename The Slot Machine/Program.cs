﻿namespace The_Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {//Design a game where the user can play a make believe slot machine
         //How do I want my slot machine to work?
         //What are the winning combinations?
         //Fill array with random numbers
         //Output that array
         //Check if middle row is all the same
         //Output win/lose
         //Keep track of money
         //Implement more game modes (multiple lines/diagonals...)
         //Create a menu for the game
            const int ALL_HORIZONTALS = 1;
            const int ALL_VERTICALS = 2;
            const int CENTER_LINE = 3;    
            const int DIAGONALS = 4; 
            const int COLUMNS_HORIZONTALS = 3;
            const int COLUMNS_VERTICALS = 3;
            Random number = new Random();
            const int LOWER_RANGE_RANDOM_NUM = 1;
            const int HIGHER_RANGE_RANDOM_NUM = 4;
            const int ROW_SIZE = 3;
            const int COLUMN_SIZE = 3;
            
            Console.WriteLine("SLOT MACHINE");
            Console.WriteLine();
            Console.WriteLine("Player decide which lines to play, £1 per line");
            Console.WriteLine();
            Console.WriteLine("LINE OPTIONS : 1 = All horizontals, 2 = All verticals, 3 = Center line, 4 = diagonals");
            Console.WriteLine();

            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you entered : " + answer);
            int[,] grid = new int[ROW_SIZE,COLUMN_SIZE];

            //Fill the Grid with random number between 1 and 4
            for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
            {
                for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                {
                  //grid[indexRow, indexColumn] = 1;
                    grid[indexRow, indexColumn] = number.Next(LOWER_RANGE_RANDOM_NUM,HIGHER_RANGE_RANDOM_NUM);
                }
            }  
            //Print the content of the Grid
            for (int indexRow = 0; indexRow< COLUMNS_HORIZONTALS; indexRow++)
            {
                for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                {
                   Console.WriteLine(grid[indexRow, indexColumn]);
                }
            }
            //Check for wins
                    bool win = true;
            if (answer == ALL_HORIZONTALS)
            {
                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                    for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                    {
                        if (grid[indexRow, 0] != grid[indexRow, indexColumn])
                        {
                            win = false;
                            break;
                        }
                    }
                }
                if (win == true)
                {
                    Console.WriteLine("You win");
                } 
            } 
            if (answer == ALL_VERTICALS)
            {
                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                     for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                     { 
                        if (grid[indexColumn,0] != grid[indexColumn, indexRow])
                        {
                            win = false;
                            break;
                        }
                     }
                }
                if (win == true)
                {
                    Console.WriteLine("YOU WIN");
                }
            }
            //123
            //321
            //213
            if (answer == CENTER_LINE)
            {
                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                    for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                    {
                        if (grid[1,0] != grid[1, 1])
                        {
                            win = false;
                            break;
                        }
                    }
                }
                if (win == true)
                {
                    Console.WriteLine("YOU WIN");
                }
            }
            if (answer == DIAGONALS)
            {
                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                    for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                    {
                        if (grid[0,0] != grid[indexColumn, indexColumn])   
                        {
                            win = false;
                            break;
                        }
                    }
                }
                if (win == true)
                {
                    Console.WriteLine("YOU WIN");
                }
            }
        }
    }
}
