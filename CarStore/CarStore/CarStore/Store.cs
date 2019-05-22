using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System;

namespace CarStore
{
    public partial class Store : IStore
    {
        public string StoreName { get; set; }
        public StoreCitys City { get; set; }
        List<Cars> cars = new List<Cars>();
        List<Order> CarOrders = new List<Order>();

        public Store(string Name, StoreCitys city)
        {
            this.StoreName = Name;
            this.City = city;
        }

        public Store()
        {
        }

        //metode
        public void AddCar(Cars car)
        {
            cars.Add(car);
            Console.WriteLine($"Car {car.Car()} has been added to {this.StoreName}");
        }

        public void EnterStore(IPerson person)
        {
            
            Console.WriteLine(value: $"{person.FullName()} entered in {StoreName}");
        }

        public void ExitStore(IPerson person)
        {

            Console.WriteLine(value: $"{person.FullName()} went out of {StoreName}");
        }

        public void ShowCars()
        {
            foreach (var car in cars)
                Console.WriteLine($"The cars available for order are:\n {car.Manufacturer} {car.Model} - release date {car.ReleaseDate} having the price {car.CarValue} euro ({car.CarValue * 4.7} lei)");
        }

        public Order Buy(string CarModel, IPerson person)
        {
            foreach (var c in cars)
            {
                if (c.Model == CarModel)
                {
                    Order order = new Order((uint)new Random().Next(1, 10), person);
                                       
                    CarOrders.Add(order);
                    Console.WriteLine($"{person.FirstName} made an order for {c.Manufacturer} {c.Model} {c.ReleaseDate.Year} at {c.CarValue} euro price. The order will arrive on {order.OrderDate.ToLongDateString()}");
                    return order;
                }

                else
                {
                    return null;
                }
            }
            return null;
        }



        public void CancelOrder(Order order)
        {
            foreach (var o in CarOrders)
            {
                if (order.OrderID == o.OrderID)
                {
                    CarOrders.Remove(order);
                    Console.WriteLine($"Order number{order.OrderID} has been removed");
                    break;
                }
            }
        }

    }  
}

