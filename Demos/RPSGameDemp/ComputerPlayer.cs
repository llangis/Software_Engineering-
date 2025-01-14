
public class ComputerPlayer : IPlayable
{
    public string TakeTurn()
    {
        Console.WriteLine("Computer is making move...");
        int move = GetRandomMove(); // 0 is rock, 1 is Paper and 2 is Scissors.

        Move m = null;


        if (move == 0)
        {
            m = new Rock();
        }
        else if (move == 1)
        {
            m = new Paper();
        }
        else if (move == 2)
        {
            m = new Scissors();
        }
        return m.GetName();
       
    }

    private int GetRandomMove()
    {
        Random random = new Random();

        int choice = random.Next(3);

        return choice;
    }
}

