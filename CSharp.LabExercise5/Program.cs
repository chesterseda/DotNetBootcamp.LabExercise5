using System;

namespace CSharp.LabExercise5.Solution1
{
    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Hello {Name}!";
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];
            Console.WriteLine("Enter 3 names");

            for(int i = 0; i < person.Length; i++)
            {
                person[i] = new Person()
                {

                    Name = Console.ReadLine()

                };
            }

            for(int i = 0; i < person.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(person[i].ToString());
            }
        }
    }
}
