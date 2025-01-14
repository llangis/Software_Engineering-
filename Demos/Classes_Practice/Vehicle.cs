using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Practice
{
    public class Vehicle
    {





        //Constructor
        public Vehicle(int argNumSeats) 
        {
            this.FuelLevel = 0;
            this.Speed = 0;
            this.NumSeats = argNumSeats;
            vehicleCount++;
            this.SerialNumber = "ABC-" + vehicleCount;
        }


        //Properties

        private static int vehicleCount = 0;
        public int FuelLevel { get; set; }
        public int Speed { get; set; }

        public int NumSeats { get; set; }

        private string SerialNumber;

        //Get
        public string GetSerialNumber()
        {
            return SerialNumber;
        }





        //Methods
        public void Move()
        {
            Console.WriteLine("I am a vehicle in motion");
        }




    }
}
