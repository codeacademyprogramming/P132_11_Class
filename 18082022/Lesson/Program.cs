using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new
            {
                Name = "Hikmet",
                Surname = "Abbsov",
                Age = 18
            };


            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Age);

            int number = 45;
            double price = 55.5;

            Student student1 = new Student();

            student1.Name = "Hikmet";
            student1.Surname = "Abbasov";
            student1.Age = 25;

            student1.Name = "Tofiq";
            student1.Gender = "Male";

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Surname);
            Console.WriteLine(student1.Age);

            Student[] students = new Student[4];

            students[0] = new Student();
            students[0].Name = "Seymur";
            students[0].Surname = "Fehradov";
            students[0].Age = 11;

            students[1] = new Student
            {
                Name = "Nermin",
                Surname = "Abbaszade",
                Age = 33
            };


            Student student2 = new Student
            {
                Name = "Abbas",
                Age = 30,
                Surname = "Eliyev"
            };

            student2.Age = 20;


            var name = "Hikmet";
            var warranyStudent1 = new WarrantyStudent(name,"Abbsov",44);

            Console.WriteLine(warranyStudent1.Name);
            Console.WriteLine(warranyStudent1.Surname);
            Console.WriteLine(warranyStudent1.Age);


        }
    }

  
}
