using System;

namespace NumberChangerWithDelegates
{
    class NumberChanger
    {
        static int num = 10;

        public static int add(int n)
        {
            num = num + n;
            return num;
        }

        public static int sub(int n)
        {
            num = num - n;
            return num;
        }

        public static int mul(int n)
        {
            num = num * n;
            return num;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            numChangeDel addChanger = new numChangeDel(add);
            addChanger(20);
            Console.WriteLine("value of {0}", num);

            numChangeDel subChanger = new numChangeDel(sub);
            subChanger(20);
            Console.WriteLine("value of {0}", num);
        }
    }

    public delegate int numChangeDel(int val);
}
