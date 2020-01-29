using System;

namespace SampleDelegate01
{
    class SampleDel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Initializing delegate and passing a method
            printDel pdel = new printDel(printTime);
            pdel(5000);

            printDel pMoney = new printDel(printMoney);
            pMoney(3500);

        }

        //delegate
        public delegate void printDel(int value);

        public static void printTime(int time)
        {
            Console.WriteLine("Time in seconds is "+time);
        }

        public static void printMoney(int dollars)
        {
            Console.WriteLine("Money I received $"+dollars);
        }
    }
}
