using System;

namespace CSharp.LabExercise5.Solution4
{
    interface IVehicle
    {
        public void Drive();

        public bool Refuel(int gasAmount);
    }

    class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Tank is empty, no fuel.");
            }
        }

        public bool Refuel(int gasAmount)
        {
            Fuel += gasAmount;
            return true;
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("Enter gasoline amount: ");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}
