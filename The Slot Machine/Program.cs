namespace The_Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ALL_HORIZONTALS = 1;
            const int ALL_VERTICALS = 2;
            const int CENTER_LINE = 3;    
            const int DIAGONALS = 4; 
            const int COLUMNS_HORIZONTALS = 3;
            const int COLUMNS_VERTICALS = 3;
            Random number = new Random();
            List<int> lines = new List<int>(3);
            //Create a menu for the game
            Console.WriteLine("SLOT MACHINE");
            Console.WriteLine();
            Console.WriteLine("Player decide which lines to play, £1 per line");
            Console.WriteLine();
            Console.WriteLine("LINE OPTIONS : 1 = All horizontals, 2 = All verticals, 3 = Center line, 4 = diagonals");
            Console.WriteLine();
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered : " + answer);
            int[,] Grid = new int[3,3];
            for (int lineIndex = 0; lineIndex < COLUMNS_HORIZONTALS; lineIndex++)
            {
                for (int lineIndex2 = 0;lineIndex2 < COLUMNS_VERTICALS; lineIndex2++)
                {

                    Console.WriteLine(Grid[lineIndex, lineIndex2] = number.Next(1,3));
                    if (Grid[LineIndex] == Grid[LineIndex2])
                    {
                        Console.WriteLine("Same value");
                    }
                }
            }
        }
    }//Design a game where the user can play a make believe slot machine
    //How do I want my slot machine to work?
    //What are the winning combinations?
    //Fill array with random numbers
    //Output that array
    //Check if middle row is all the same
    //Output win/lose
    //Keep track of money
    //Implement more game modes (multiple lines/diagonals...)
}
