using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Car:Vehicle
    {
        public Car()
        {

        }
        public Car(string brand,string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        public Car(string brand,string model,int year):this(brand,model)
        {
            this.Year = year;
        }

        public int Year;
        public double Price;
        public double Millage;

        public void Drive(double km)
        {
            Millage += km;
        }
    }
}
