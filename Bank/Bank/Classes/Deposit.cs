using System;

namespace Bank
{
    class Deposit : Account, IWithdraw
    {
        //Constructors
        public Deposit(Customer owner, double startBalance, double interestRate)
                : base(owner, startBalance, interestRate)
        {
        }

        //Methods
        public override double InterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.InterestAmount();
        }

        public void Withdraw(double withdrawedSum)
        {
            if (withdrawedSum <= 0)
            {
                throw new ArgumentException("You cannot withdraw a negative or a zero sum!");
            }

            this.Balance -= withdrawedSum;
        }
    }
}
