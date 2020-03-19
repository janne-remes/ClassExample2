using System;

namespace ClassExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Fiesta = new Car("Ford", "springgreen", 300);
            
            Car Golf = new Car("Volkswagen", "citrine", 145);
            
            Car Auto = new Car();
            
            Car Yaris = new Car();
            Yaris.brand = "Toyota";
            Yaris.color = "cyan";
            Yaris.color = "purple";
            Yaris.maximumSpeed = 125;

            //Console.WriteLine($"{Fiesta.brand}, {Fiesta.color}");
            //Console.WriteLine($"{Golf.brand}, {Golf.color}");
            //Console.WriteLine($"{Auto.brand}, {Auto.color}");
            
            Fiesta.carInfo();
            Fiesta.carSpeedAnalysis();

            Golf.carInfo();
            Golf.carSpeedAnalysis();

            Auto.carInfo();
            Auto.carSpeedAnalysis();
            
            Yaris.carInfo();
            Yaris.carSpeedAnalysis();
        }
    }

    class Car
    {
        public string brand;
        public string color;
        public int maximumSpeed;

        public Car()
        {
            brand = "automobile";
            color = "black";
            maximumSpeed = 50;
        }

        public Car(string brand, string color, int maximumSpeed)
        {
            this.brand = brand;
            this.color = color;
            this.maximumSpeed = maximumSpeed;
        }

        public void carInfo()
        {
            //return $"Brand: {brand}, color: {color}.";
            Console.WriteLine($"brand {brand} - color {color} - maximum speed {maximumSpeed}");
        }

        public void carSpeedAnalysis()
        {
            if(maximumSpeed < 100)
            {
                Console.WriteLine($"This {brand} is very slow!");
            }

            else if(maximumSpeed > 100 && maximumSpeed < 250)
            {
                Console.WriteLine($"This {brand}'s speed is normal.");
            }

            else
            {
                Console.WriteLine($"This {brand} can go very fast!");
            }
        }
    }
}
