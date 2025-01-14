namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Luc");
            Person p2 = new Person("Chrysa");
            Person p3 = new Person("Mir");

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p3.Name);
            Console.WriteLine(Person.PopulationCounter);
        }
    }
}
