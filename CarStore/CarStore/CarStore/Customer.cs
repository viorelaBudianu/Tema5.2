using System;

namespace CarStore
{
    public class Customer : IPerson
    {
        private string firstName;
        private string lastName;
        private int age;
        private string adress;
        
        // Constructor
       public Customer(string FirstName, string LastName, int age)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.Age = age;
            
        }
        //proprietati

        public string FirstName
        { get
            { return this.firstName; }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("First name cannot be null");
                    
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null");

                }
                this.lastName = value;
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
                if (value<18||value==null)
                {
                    throw new ArgumentException("The buyer should be 18 years old at least!");
                }
                this.age = value;
            }
        }

        public string Adress
        {
            get
            {
                return this.adress;
            }

            set
            {
                this.adress = value;
            }
        }

        
        //Methods
        public string FullName()
        {
            return lastName+" "+FirstName;
        }
    }
}
