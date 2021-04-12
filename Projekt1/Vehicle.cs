using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt1;

namespace MDIApp

{
    public class Vehicle
    {
        public string brand { get; set; }
        public int maxSpeed { get; set; }
        public DateTime prodDate { get; set; }
        public VehicleType vehicleType { get; set; }

        public Vehicle(string brand, int maxSpeed, DateTime prodDate, VehicleType vehicleType)
        {
            this.brand = brand;
            this.maxSpeed = maxSpeed;
            this.prodDate = prodDate;
            this.vehicleType = vehicleType;
        }
    }
}
