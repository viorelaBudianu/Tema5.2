using System;

namespace Bank
{
    // All accounts have customer, balance and interest rate(monthly based).
    public abstract class Account:IDeposite,IRemunerable
    {
        private Customer customer;
        private double balance;
        private double InterestRate;
        private DateTime openDate;


        //Constructor
        public Account(Customer owner, double startBalance, double interestRate)
        {
            this.customer = owner;
            this.balance = startBalance;
            this.InterestRate = interestRate;
            this.openDate = DateTime.Now; // cand deschidem un account nou, mereu va fi data curenta
        }

        //Proprietati
        public Customer Owner

        {
            get
            {
                return this.Owner;
            }
        }

        public double interestRate
        {
            get
            {
                return this.InterestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate should be a positive value!");
                }

                this.InterestRate = value;
            }
        }
        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        public int Months
        {
            get
            {
                return (DateTime.Now.Year * 12 + DateTime.Now.Month) -
                    (this.openDate.Year * 12 + this.openDate.Month);
            }
        }

        //Methods
        public void Deposite(double receivedSum)
        {
            if (receivedSum <= 0)
            {
                throw new ArgumentException("You cannot deposite a negative or a zero sum!");
            }

            this.Balance += receivedSum;
        }
        public virtual double InterestAmount()
        {
            return (this.Months * this.InterestRate);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{this.Owner} opened a new {this.GetType().Name} account on {openDate}. Balance:{this.balance}, InterestRate: {InterestAmount()}");
        }
    }
}
