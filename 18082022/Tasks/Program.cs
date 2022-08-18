using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", "E200",2015);
           
            car1.Price = 43000;


            Car car2 = new Car("BMW","X6",2012)
            {
                Price = 25000
            };

            car2.Price = 30000;

            Car[] cars = new Car[4]
            {
                car1,
                car2,
                new Car
                {
                    Brand = "Mercedes",
                    Model = "CLA",
                    Price = 34000,
                    Year = 2013
                },
                new Car
                {
                    Brand = "Mercedes",
                    Model = "S500",
                    Price = 220000,
                    Year = 2018
                }
            };


            var result = CalcAvgPrice(cars);

            Console.WriteLine(result);

            //Human human1 = new Human();
            Student student1 = new Student();

            Car e200 = new Car();
            e200.Drive(14);
            e200.Drive(10);
            Console.WriteLine(e200.Millage);
        }


        static double CalcAvgPrice(Car[] cars)
        {
            double totalPrice = 0;

            for(int i = 0; i < cars.Length; i++)
            {
                totalPrice += cars[i].Price;
            }

            double avg = totalPrice / cars.Length;

            return avg;
        }
    }
}
