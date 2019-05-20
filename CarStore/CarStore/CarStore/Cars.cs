using System;

namespace CarStore
{
    public class Cars : IVehicle
    {
        private string manufacturer;
        private string model;
        private DateTime releaseDate;
        private double ValueCar;

        //constructor
        public Cars(string Manufacturer, string Model, DateTime ReleaseDate)
        {
            this.manufacturer = Manufacturer;
            this.model = Model;
            this.releaseDate = ReleaseDate;
        }

        //proprietati
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public DateTime ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }
        public double CarValue
        {
            get
            {
                return this.ValueCar;
            }
            set
            {
                if (value==0)
                {
                    throw new ArgumentException("Value of the car should not be empty!");
                }
                this.ValueCar = CarValue;
            }
        }

        //metode
        public string Car()
        {
            return this.manufacturer + " " + this.model + " " +Convert.ToString(this.releaseDate.Year);
        }

    }
}
