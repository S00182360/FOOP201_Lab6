using System;

namespace FOOP201_Lab6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Bill bill1 = new Bill("Sam", 35.99m);
            Bill bill2 = new Bill("John", 29.99m);
            Console.WriteLine(bill1.ToString());
            Console.WriteLine(bill2.ToString());

            OverDueBill bill3 = new OverDueBill("Ronan", 86.99m, 5);


            Console.WriteLine(bill3);
        }
    }

    class Bill
    {
        public Bill(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }
        public Bill()
        {
        }
        public string Name
        {
            get;
            set; 
        }
        public decimal Amount
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0}\nName: {1}\nAmount: {2}", GetType(), Name, Amount);
        }
    }

    class OverDueBill : Bill
    {
        public OverDueBill(string name, decimal amount) : base(name, amount)
        {
        }
        public OverDueBill(string name, decimal amount, int days) : base(name, amount)
        {
            Days = days;
        }
        public int Days
        {
            get;
            set;
        }
        public override string ToString()
        {
            return base.ToString() + "\nDays Overdue: " + Days;
        }
    }

}
