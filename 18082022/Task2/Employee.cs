using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Employee:Human
    {
        public Employee(string name,string surname):base(name,surname)
        {

        }
        public string Position;
        public double Salary;
    }
}
