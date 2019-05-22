using System;

namespace CarStore
{
    public class Cars : IVehicle
    {
        private string Name;
        private string model;
        private DateTime releaseDate;
        private double ValueCar;

        //constructor
        public Cars(string Manufacturer, string Model, DateTime ReleaseDate)
        {
            this.Name = Manufacturer;
            this.model = Model;
            this.releaseDate = ReleaseDate;
        }

        //proprietati
        public string Manufacturer
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
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
                else
                {
                    this.ValueCar = value;
                }
                
            }
        }

        string IProducer.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //metode
        public string Car()
        {
            return this.Name + " " + this.model + " " +Convert.ToString(this.releaseDate.Year);
        }

    }
}
