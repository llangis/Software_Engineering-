public class HumanPlayer : IPlayable
{
    public string TakeTurn()
    {
        Console.WriteLine("Choose your move: ");
        Console.WriteLine("R, P or S");
        string input = Console.ReadLine();

        Move m;

        if(input == "R")
        {
            m = new Rock();
        }
        else if(input == "P")
        {
            m = new Paper();
        }
        else if (input == "S")
        {
            m = new Scissors();
        }
        else
        {
            return "Invalid move!";
        }

        return m.GetName();

    }
}

