using System;

namespace CSharp.LabExercise5.Solution3
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("{0} is studying.", Name);
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }

        public void Explain()
        {
            Console.WriteLine("{0} is explaining", Name);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int indexTotal = 3;
            Person[] persons = new Person[indexTotal];
            

            for (int i = 0; i < indexTotal; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter Teacher's name: ");
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Console.Write("Enter Student's name: ");
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < indexTotal; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }
    }
}
