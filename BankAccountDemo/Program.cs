using System;

namespace BankAccountDemo
{
    public class BankAccount
    {
        private double balance;
        private string custName;

        public BankAccount(double balnance, string custName)
        {
            this.balance = balnance;
            this.custName = custName;
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string Name
        {
            get { return this.custName; }
            set { this.custName = value; }
        }

        public double deposit(double amount)
        {
            return (balance += amount);
        }

        public double withdraw(double amount)
        {
            double retValue;
            if (balance >= amount)
            {
                retValue = balance - amount;
            }
            else
            {
                retValue = -99;
            }
            return retValue;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
