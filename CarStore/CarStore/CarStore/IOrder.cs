using System;

namespace CarStore
{
    public interface IOrder
    {
        uint OrderID { get; set; }
        
        string Buyer { get; set; }  // buyer in main o sa fie = customer.FullName()
        string Product { get; set; } // Product o sa fie dat de metoda Car() din clasa Cars
        DateTime OrderDate { get; set; }
        DateTime OrderArrival { get; set; }
        uint Quantity { get; set; }

        double TotalOrder(double Price, uint Quantity);

    }
}
