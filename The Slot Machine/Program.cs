namespace The_Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TOP_HORIZONTAL = 1;
            const int MIDDLE_HORIZONTAL = 2;
            const int BOTTOM_HORIZONTAL = 3;    
            const int TOP_VERTICAL = 4; 
            const int MIDDLE_VERTICAL = 5;
            const int BOTTOM_VERTICAL = 6;
            const int FIRST_DIAGONAL = 7;
            const int SECOND_DIAGONAL = 8;
            const int ALL_LINES = 9;
            //Create a menu for the game
            Console.WriteLine("SLOT MACHINE");
            Console.WriteLine();
            Console.WriteLine("Player decide which lines to play, £1 per line");
            Console.WriteLine();
            Console.WriteLine("LINE OPTIONS : 1 = Top horizontal, 2 = Middle horizontal, 3 = Bottom horizontal, 4 = Top vertical, 5 = Middle vertical, 6 = Bottom vertical, 7 = First diagonal, 8 = Second diagonal, 9 = all lines");
            Console.WriteLine();
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered : " + answer);
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
