using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class WarrantyStudent:Student
    {
        public WarrantyStudent()
        {

        }
        public WarrantyStudent(byte age)
        {
            Age = age;
            Console.WriteLine("zemanetli telebe yaradildi");
        }

        public WarrantyStudent(string name,string surname,byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }

        public string PrevGroupNo;
    }
}
