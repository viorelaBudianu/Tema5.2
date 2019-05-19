using System;

namespace Bank
{
    public class Customer
    {
        private string name;
        private CustomerType Type;

        //Constructor
        public Customer(string name, CustomerType type)
        {
            this.name = name;
            this.Type = type;
        }
        //proprietati
        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please insert a name!");
                }
                else
                {
                    if (char.IsUpper(value[0]))
                    {
                        this.name = value;
                    }
                    else
                    {
                        Console.WriteLine("First letter should be Capital letter!");
                    }
                }
            }
        }
        public CustomerType CustomerType
        {
            get
            {
                return this.Type;
            }
            set
            {
                this.Type = value;
            }
        }
    }
}
