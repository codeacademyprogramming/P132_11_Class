using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Student:Human
    {
        public Student()
        {

        }
        public Student(string name,string surname,string groupNo):base(name,surname)
        {
            this.GroupNo = groupNo;
            Console.WriteLine("Telebe yaradildi");
        }


        public string GroupNo;
        public byte Point;
    }
}
