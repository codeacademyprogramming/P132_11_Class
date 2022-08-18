using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Human
    {
        public Human()
        {

        }
        public Human(string name)
        {
            this.Name = name;
            Console.WriteLine("Insan yaradildi");
        }

        public Human(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name;
        public string Surname;
    }
}
