using System;

namespace Car
{
    class Car
    {
        private int carID;
        private string carBrand;

        public Car(int carID, string carBrand)
        {
            this.carID = carID;
            this.carBrand = carBrand;
        }

        public int vin
        {
            get { return this.carID;}
            set {carID = value; }
        }

        public String brand
        {
            get { return this.carBrand; }
            set { carBrand = value; }
        }

        public override string ToString()
        {
            return "Car ID: " + this.carID + "\nCar Brand: " + this.carBrand;
        }
    }///end car

    //class CarDriver
    //{
    //    public static void Main(String[] args)
    //    {
    //        Car c1 = new Car(123, "Benz");
    //        Car c2 = new Car(234, "Toyota");

    //        Console.WriteLine(c1);
    //        c1.vin = 989;
    //        Console.WriteLine(c1.brand);
    //    }
    //}
}
