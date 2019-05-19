namespace Bank
{
    public class Loan : Account
    {
        //Constructor 
        public Loan(Customer customer, double StartBalance, double iRate):base(customer,StartBalance,iRate)
        { }

        //Metoda
        public override double InterestAmount()
        {
            
            if (this.Owner.CustomerType == CustomerType.Individual && this.Months < 3)
            {
                return 0;
            }

            if (this.Owner.CustomerType == CustomerType.Company && this.Months < 2)
            {
                return 0;
            }

            return base.InterestAmount();
        }
    }
}
