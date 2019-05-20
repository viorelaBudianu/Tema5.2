using System;

namespace CarStore
{
    public interface IVehicle
    {
        string Manufacturer { get; set; }
        string Model { get; set; }
        DateTime ReleaseDate { get; set; }
        
    }
}
