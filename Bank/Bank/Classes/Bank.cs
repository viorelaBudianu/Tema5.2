using System;
using System.Collections.Generic;

namespace Bank
{
    public class Bank
    {
        private string name;
        private List<Account> allAccounts;

        //Constructors
        public Bank(string name)
        {
            this.name = name;
            this.allAccounts = new List<Account>();
        }
        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null)
                    this.name = value;
                else
                {
                    Console.WriteLine("Insert a valid name for bank");
                }
            }
        }

        internal List<Account> AllAccounts
        {
            get
            {
                return new List<Account>(this.allAccounts);
            }
        }

        //Methods
        public void AddAccount(Account newAccount)
        {
            this.allAccounts.Add(newAccount);
        }

        public void Display()
        {
            Console.WriteLine($"The Bank {this.Name} has {this.AllAccounts.Count} accounts opened in it.");
        }

        public void InfoBank()
        {
            Console.WriteLine($"The bank has the name {this.Name}\nAnd the accounts:");

            foreach (var b in allAccounts) // Imi da eroarea Process is terminated due to StackOverflowException.
                                           // si nu stiu de la ce... stiu sigur ca e de la asta, ca o da de cand am construit metoda InfoBank
                                           // am o banuiala ca e de la proprietatea List<Account> AllAccounts
            {
                Console.WriteLine($"Owner:{b.Owner} Balance:{b.Balance} InterestRate:{b.interestRate} Months:{b.Months}");
            }
        }


    }
}
