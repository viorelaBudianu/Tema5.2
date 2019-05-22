using System.Collections.Generic;
using System;

namespace CarStore
{
    public class Order : IOrder
    {
        private uint OrderId; //OrderID trebuie sa fie unic, si ca sa-l facem unic, avem o lista 
        private List<uint> Orders = new List<uint>(); // si cand initializam order, o sa verificam daca valoarea pt OrdeId se afla in lista  
        private IPerson buyer;
        private string product;
        private uint quantity;
        private double ValueOfProduct;  //ar trebui sa fie pretul masinii 
        private Store store = new Store();
        public DateTime OrderDate {get; set;} //orderDate ar trebui sa fie mereu data curenta, deci o sa facem proprietatea by default cu Today/Now
        public DateTime OrderArrival { get; set; }



        //constructor
        public Order()
        { }
        public Order (uint Id, IPerson buyer)
        {
            if (Orders.Contains(Id))
            {
                Console.WriteLine("Please insert a different OrderID, it should be unique");
            }
            else
            {
                this.OrderId = Id;
                Orders.Add(Id);
                this.OrderDate = DateTime.Now;
                if(store.StoreName=="FordStore")
                {
                    this.OrderArrival = this.OrderDate.AddDays(28);
                }
                    
                if (store.StoreName=="SkodaStore")
                    this.OrderArrival = this.OrderDate.AddDays(18);
            }
            this.buyer = buyer;
        }

        //proprietati
        
        public uint OrderID
        {
            get
            {
                return this.OrderId;
            }
            set
            {
                if (Orders.Contains(value))
                {
                    Console.WriteLine("Please insert a different OrderID, it should be unique");
                }
                else
                {
                    this.OrderId = value;
                    Orders.Add(value);
                }
            }
        }

        public IPerson Buyer
        {
            get
            {
                return this.buyer;
            }
            set
            {
                this.buyer = value;
            }
        }

        public string Product
        {
            get
            {
                return this.product;
            }
            set
            {
                this.product = value;
            }
        }

        public uint Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if(value==0)
                {
                    throw new ArgumentException("Quantity should not be 0!");
                }
                this.quantity = value;
            }
        }

        public double ProductValue
        {
            get
            {
                return this.ValueOfProduct;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Value of product should be a valid price!");
                this.ValueOfProduct = value;
            }
        }

        //metode 
      

        public double TotalOrder(double Price, uint Quantity)
        {
            return Price * Quantity;
        }





    }
}
