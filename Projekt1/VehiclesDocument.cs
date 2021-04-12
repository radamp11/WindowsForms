using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIApp
{
    public class VehiclesDocument
    {
        public List<Vehicle> vehicles { get; set; } = new List<Vehicle>();

        public event Action<Vehicle> AddVehicleEvent;
        public event Action<Vehicle> UpdateVehicleEvent;
        public event Action<Vehicle> RemoveVehicleEvent;

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            AddVehicleEvent?.Invoke(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
            RemoveVehicleEvent?.Invoke(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            UpdateVehicleEvent?.Invoke(vehicle);
        }
    }
}
