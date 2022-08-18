using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adi daxil edin");
            string name = Console.ReadLine();
            Human human1 = new Human(name,"Abbsov");

            human1.ShowInfo();
        }


    }
}
