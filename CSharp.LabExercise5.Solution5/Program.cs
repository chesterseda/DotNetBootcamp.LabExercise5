using System;

namespace CSharp.LabExercise5.Solution5
{
    abstract class Animal
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public abstract void Eat();
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("{0} is eating.", this.Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal dog = new Dog();
            Console.Write("Enter your desired name of the dog: ");
            dog.SetName(Console.ReadLine());

            Console.WriteLine("Name of Dog: {0}", dog.GetName());
            dog.Eat();

        }
    }
}
