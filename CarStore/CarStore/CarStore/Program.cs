using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System;

namespace CarStore
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Today);
            Cars ford = new Cars("Ford", "Focus", new DateTime(2015, 12, 25));
            Store store1 = new Store("FordStore",StoreCitys.Bucuresti);
            store1.AddCar(ford);
            
            
            


        }
    }
}
