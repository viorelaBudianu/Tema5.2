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
    }
}
