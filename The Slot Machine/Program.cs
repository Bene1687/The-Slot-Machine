namespace The_Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {//Create a menu for the game
            Console.WriteLine("SLOT MACHINE");
            Console.WriteLine();
            Console.WriteLine("Player decide which lines to play, £1 per line");
            Console.WriteLine();
            Console.WriteLine("LINE OPTIONS : 1 = Top horizontal, 2 = Middle horizontal, 3 = Bottom horizontal, 4 = Top vertical, 5 = Middle vertical, 6 = Bottom vertical, 7 = First diagonal, 8 = Second diagonal, 9 = all lines");
            Console.WriteLine();
            Console.ReadLine();
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
