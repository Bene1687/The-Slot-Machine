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
            for (int lineIndex = 0; lineIndex < COLUMNS_HORIZONTALS; lineIndex++)
            {
                for (int columnIndex = 0; columnIndex  < COLUMNS_VERTICALS; columnIndex++)
                {
                    Grid[lineIndex, columnIndex] = number.Next(1,4);
                }
            }  
            //Print the content of the Grid
            for (int lineIndex = 0; lineIndex < COLUMNS_HORIZONTALS; lineIndex++)
            {
                for (int columnIndex = 0; columnIndex  < COLUMNS_VERTICALS; columnIndex++)
                {
                   Console.WriteLine(Grid[lineIndex, columnIndex]);
                }
            }
            //Check for wins
            for (int lineIndex = 0; lineIndex < COLUMNS_HORIZONTALS; lineIndex++)
            {
                for (int columnIndex = 0; columnIndex  < COLUMNS_VERTICALS; columnIndex++)
                {
                    if ((Grid[lineIndex, 0], Grid[columnIndex, 0]) == (Grid[lineIndex, 0], Grid[columnIndex, 1]))
                    {
                        Console.WriteLine("Same value");
                    }
                    if ((Grid[lineIndex, 0], Grid[columnIndex, 0]) == (Grid[lineIndex, 0], Grid[columnIndex, 2]))
                    {
                        Console.WriteLine("You win");
                    }
                }
            }
                
            


        }
    }
}
