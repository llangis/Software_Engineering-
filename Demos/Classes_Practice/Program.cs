namespace Classes_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle jeep = new Vehicle(4);
            Vehicle porsche = new Vehicle(2);


            jeep.Move();
            
            Console.WriteLine($"My serial number is: {jeep.GetSerialNumber()}");
            porsche.Move();
            Console.WriteLine($"My serial number is: {porsche.GetSerialNumber()}");


            Car camry = new Car(false, 4);

            camry.Drive();
            Console.WriteLine($"My serial number is: {camry.GetSerialNumber()}");

        }
    }
}
