using System;

namespace CarStore
{
    public interface IVehicle:IProducer
    {
        string Manufacturer { get; set; }
        string Model { get; set; }
        DateTime ReleaseDate { get; set; }
        
    }
}
