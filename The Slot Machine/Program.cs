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
            Console.WriteLine("LINE OPTIONS : ");
            Console.WriteLine();
            Console.WriteLine(" 1 = Top horizontal line");
            Console.WriteLine();
            Console.WriteLine(" 2 = Middle horizontal line");
            Console.WriteLine();
            Console.WriteLine(" 3 = Bottom horizontal line");
            Console.WriteLine();
            Console.WriteLine(" 4 = Top vertical line");
            Console.WriteLine();
            Console.WriteLine(" 5 = Middle vertical line");
            Console.WriteLine();
            Console.WriteLine(" 6 = Bottom vertical line");
            Console.WriteLine();
            Console.WriteLine(" 7 = First diagonal line");
            Console.WriteLine();
            Console.WriteLine(" 8 = Second diagonal line");
            Console.WriteLine();    
            Console.WriteLine(" 9 = all lines");
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
