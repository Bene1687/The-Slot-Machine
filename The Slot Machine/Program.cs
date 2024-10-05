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
            
            Console.WriteLine("SLOT MACHINE");
            Console.WriteLine();
            Console.WriteLine("Player decide which lines to play, £1 per line");
            Console.WriteLine();
            Console.WriteLine("LINE OPTIONS : 1 = All horizontals, 2 = All verticals, 3 = Center line, 4 = diagonals");
            Console.WriteLine();

            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you entered : " + answer);
            int[,] Grid = new int[3,3];

            //Fill the Grid with random number between 1 and 4
            for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
            {
                for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                {
                   //Grid[indexRow, indexColumn] = 1;
                    Grid[indexRow, indexColumn] = number.Next(LOWER_RANGE_RANDOM_NUM,HIGHER_RANGE_RANDOM_NUM);
                }
            }  
            //Print the content of the Grid
            for (int indexRow = 0; indexRow< COLUMNS_HORIZONTALS; indexRow++)
            {
                for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                {
                   Console.WriteLine(Grid[indexRow, indexColumn]);
                }
            }
            //Check for wins
            for (int indexRow = 0; indexRow < COLUMNS_HORIZONTALS; indexRow++)
            {
                for (int indexColumn = 0; indexColumn  < COLUMNS_VERTICALS; indexColumn++)
                {
                    while (answer == ALL_HORIZONTALS)
                    {

                        if ((Grid [indexRow,LOWER_RANGE_RANDOM_NUM], Grid[indexColumn,LOWER_RANGE_RANDOM_NUM]) == (Grid [indexRow,HIGHER_RANGE_RANDOM_NUM],Grid[indexColumn,HIGHER_RANGE_RANDOM_NUM]))
                        {
                            Console.WriteLine("You win");
                        }
                    }
                }
            }
        }
    }
}
