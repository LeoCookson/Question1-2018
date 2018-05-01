using System;

namespace Question1
{
    //Create class
    class Car {
        private string _color;
        private string _make;
        private string _gearbox;


       //Get, Set methods 
        public string GetColor() {
            return _color;
        }

        public void SetColor(string color) {
            _color = color;
        }

        public string GetMake() {
            return _make;
        }

        public void SetMake(string make) {
            _make = make;
        }

        public string GetGearbox() {
            return _gearbox;
        }

        public void SetGearbox(string gearbox) {
            _gearbox = gearbox;
        }

        //Returns the description of the car
        public string DescribeCar() {
            return $"This car is a {GetColor()} {GetMake()} with a {GetGearbox()} transmission";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter new car details below:");
            Console.Write("Color: ");
            var color = Console.ReadLine();
            Console.Write("Make: ");
            var make = Console.ReadLine();
            Console.Write("Gearbox: ");
            var gearbox = Console.ReadLine();

            Console.WriteLine();

            var car = new Car();
            car.SetMake(make);
            car.SetColor(color);
            car.SetGearbox(gearbox);
            Console.WriteLine(car.DescribeCar());

           
        }
    }
}

