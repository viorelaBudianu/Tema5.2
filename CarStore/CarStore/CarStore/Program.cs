using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System;

namespace CarStore
{
    public interface IProducer
    {
        string Name { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Today);
            Cars ford = new Cars("Ford", "Focus", new DateTime(2015, 12, 25));
            ford.CarValue = 15000;
            Cars dacia = new Cars("Dacia", "Logan", new DateTime(2018, 09, 15));
            dacia.CarValue = 25000;
            Cars ford2 = new Cars("Ford", "Mondeo", new DateTime(2008, 06, 02));
            ford2.CarValue = 10000;
            Cars ford3 = new Cars("Ford", "Fiesta", new DateTime(2015, 03, 06));
            ford3.CarValue = 17000;
            Cars bmw = new Cars("BMW", "X3", new DateTime(2015, 12, 25));
            bmw.CarValue = 45000;
            Cars bmw1 = new Cars("BMW", "X1", new DateTime(2018, 12, 31));
            bmw1.CarValue = 85000;
            Store store1 = new Store("FordStore",StoreCitys.Bucuresti);
            store1.AddCar(ford);
            store1.AddCar(ford2);
            store1.AddCar(ford3);
            store1.AddCar(bmw);

            Store store2 = new Store("SkodaStore",StoreCitys.Bucuresti);
            Cars ford12 = new Cars("Ford", "Focus", new DateTime(2015, 12, 31));
            ford12.CarValue = 14000;
            store2.AddCar(ford12);
            store2.AddCar(bmw1);
            store2.AddCar(dacia);
            store2.AddCar(bmw);


            //IPerson person = new Customer("Alex", "Ionescu", 17);
            IPerson Alex = new Customer("Alex", "Ionescu", 18);
            store1.EnterStore(Alex);
            store1.ShowCars();
            var order1 =store1.Buy("Focus", Alex);
            store1.ExitStore(Alex);

            store2.EnterStore(Alex);
            store2.ShowCars();
            store2.ExitStore(Alex);
            store1.EnterStore(Alex);
            store1.CancelOrder(order1);
            store1.ExitStore(Alex);
            store2.EnterStore(Alex);
            store2.Buy("Focus", Alex);







        }
    }
}
