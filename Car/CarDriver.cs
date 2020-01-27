using System;
using System.Collections.Generic;
using System.Text;
using Car;
namespace Car
{
    class CarDriver
    {
        public static void Main(String[] args)
        {
            Car c1 = new Car(123, "Benz");
            Car c2 = new Car(234, "Toyota");

            Console.WriteLine(c1);
            c1.vin = 989;
            Console.WriteLine(c1.brand);
        }
    }
}
