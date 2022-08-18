using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Human
    {
        public Human(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name;
        public string Surname;

        public void ShowInfo()
        {
            Console.WriteLine($"Ad:{this.Name} Soyad:{this.Surname}");
        }

    }
}
