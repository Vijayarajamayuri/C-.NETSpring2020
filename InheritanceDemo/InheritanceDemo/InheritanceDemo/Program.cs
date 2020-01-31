using System;

namespace InheritanceDemo
{


    public class Employee
    {
        private String fname;
        private string lname;
        private long ssn;

        public Employee()
        {

        }

        public Employee(String fname, String lname, long ssn)
        {
            this.fname = fname;
            this.lname = lname;
            this.ssn = ssn;
        }

        public String FName
        {
            get { return this.fname; }
            set { this.fname = value; }
        }

        public String LName
        {
            get { return this.lname; }
            set { this.lname = value; }
        }

        public long SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public  virtual String getFullName()
        {

            return this.lname + "," + this.fname;
        }
        public override string ToString()
        {
            return this.ssn + " " + this.getFullName();
        }
    }

    public class HourlyEmployee : Employee
    {
        private int hoursWorked;
        private double wagRate;
        public HourlyEmployee(int hoursWorked, double wagRate, String fname, String lname, long ssn): base(fname, lname, ssn)
        {
            this.hoursWorked = hoursWorked;
            this.wagRate = wagRate;
        }

        public HourlyEmployee() : base()
        {

        }

        public int HRSWorked
        {
            get { return this.hoursWorked; }
            set { this.hoursWorked = value; }
        }

        public double Rate
        {
            get { return this.wagRate; }
            set { this.wagRate = value; }
        }

        public override String getFullName()
        {
            return base.FName + "$$" + base.LName;
        }

        public override string ToString()
        {
            return base.ToString() + "$" + this.hoursWorked * this.wagRate;
        }
    }

    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("Joe", "Smith", 909290422);
            Console.WriteLine(emp1.getFullName());
            emp1.FName = "Ben";
            Console.WriteLine(emp1.getFullName());
            Employee hremp = new HourlyEmployee(12, 10, "John", "Beck", 965764527);
            Console.WriteLine(hremp.getFullName());
            Console.WriteLine(hremp.ToString());
        }
    }

}       

    

