using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreShop
{
    public interface IPerson
    {
       

    }
    public class Customer
    {
        private string name;
        private int age;

        // Constructor
        public Customer(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }
        //Proprietati
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Please provide a valid name");
                }
                this.name = Name;
            }
        }

        public int Age
        {
            get
            {
                return this.age;

            }

            set
            {
                if (value<18)
                {
                    throw new ArgumentException("The customer should have minimum 18 years old");
                }
                this.age = Age;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
