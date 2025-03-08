namespace The_Slot_Machine
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
            const int DIVIDING_TO_GET_CENTRE = 2;

            Console.WriteLine("SLOT MACHINE");
            Console.WriteLine();
            Console.WriteLine("Player decide which lines to play, £1 per line");
            Console.WriteLine();
            Console.WriteLine("LINE OPTIONS : 1 = All horizontals, 2 = All verticals, 3 = Center line, 4 = diagonals");
            Console.WriteLine();

            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you entered : " + answer);
            int[,] grid = new int[ROW_SIZE, COLUMN_SIZE];

            //Fill the Grid with random number between 1 and 4
            for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
            {
                for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                {
                    //grid[indexRow, indexColumn] = 1;
                    grid[indexRow, indexColumn] = number.Next(LOWER_RANGE_RANDOM_NUM, HIGHER_RANGE_RANDOM_NUM);
                }
            }
            //Print the content of the Grid
            for (int indexRow = 0; indexRow< COLUMNS_HORIZONTALS; indexRow++)
            {
                Console.WriteLine();
                for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                {
                    Console.Write(grid[indexRow, indexColumn]);

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
            }
            if (answer == ALL_VERTICALS)
            {
                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                    for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                    {
                        if (grid[indexColumn, 0] != grid[indexColumn, indexRow])
                        {
                            win = false;
                            break;
                        }
                    }
                }
            }
            //123
            //321
            //213
            if (answer == CENTER_LINE)
            {
                int CentreOfTheGrid = ROW_SIZE / DIVIDING_TO_GET_CENTRE;

                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                    for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                    {
                        if (grid[CentreOfTheGrid, 0] != grid[CentreOfTheGrid, indexRow])
                        {
                            win = false;
                            break;
                        }
                    }
                }
            }
            

            bool winFirstDiagonal = true;
            bool winSecondDiagonal = true;
            if (answer == DIAGONALS)
            {
                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                    for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                    {

                        if (grid[0, 0] != grid[indexColumn, indexColumn])
                        {
                            winFirstDiagonal = false;
                            break;
                        }
                        if (grid[indexRow, indexRow] != grid[indexColumn, 0])
                        {
                            winFirstDiagonal = false;
                            break;
                        }
                        //
                    }
                }
               
                for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
                {
                    for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                    {
                        if (grid[indexRow, COLUMN_SIZE-1-indexRow] != grid[indexColumn, 1])
                        {
                            winSecondDiagonal = false;
                            break;
                        }
                    }
                }
                 //&& AND
                if (winFirstDiagonal && winSecondDiagonal)
                {
                    win = true;
                }
            }

            if (win)
            {
                Console.WriteLine();
                Console.Write("YOU WIN");
            }


        }
    }
}
