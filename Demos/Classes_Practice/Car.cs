using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Practice
{
    public class Car : Vehicle
    {
        //Constructor
        public Car(bool argFWD,int argNumSeats): base(argNumSeats)
        {
            this.IsFourWheelDrive = argFWD;
           
        }




        //Properties
        public bool IsFourWheelDrive {  get; set; }



        //Method

        public void Drive()
        {
            Console.WriteLine("I'm a car driving");
        }
    }
}
