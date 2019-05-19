namespace Bank
{
    public  class Mortgage : Account
    {
        //Constructors
        public Mortgage(Customer owner, double startBalance, double interestRate)
            : base(owner, startBalance, interestRate)
        {
        }

        //Methods
        public override double InterestAmount()
        {
            if (this.Owner.CustomerType == CustomerType.Individual && this.Months < 6)
            {
                return 0;
            }

            if (this.Owner.CustomerType == CustomerType.Company && this.Months <= 12)
            {
                return (base.InterestAmount() / 2);
            }

            return base.InterestAmount();
        }
    }
}
