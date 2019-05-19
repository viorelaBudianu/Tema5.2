using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {

        static void Main(string[] args)
        {
            Bank bank = new Bank("WBank");
            

            Customer newOwner = new Customer("Vio", CustomerType.Individual);
            Deposit myDeposit = new Deposit(newOwner, 1200, 3.45d);
            bank.AddAccount(myDeposit);
            bank.Display();
            Customer secondOwner = new Customer("SRL", CustomerType.Company);
            Mortgage SRL = new Mortgage(secondOwner, 500, 5.50d);
            bank.AddAccount(SRL);
            bank.Display();
            //bank.InfoBank();



           
        }
    }
}
