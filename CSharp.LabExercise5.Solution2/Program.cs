using System;

namespace CSharp.LabExercise5.Solution2
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }

    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying.");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old.", age);
        }
    }

    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining.");
        }
    }



    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(15);
            student.Greet();
            student.ShowAge();
            student.Study();

            Professor professor = new Professor();
            professor.SetAge(39);
            professor.Greet();
            professor.Explain();
        }
    }
}
