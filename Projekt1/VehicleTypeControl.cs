using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public enum VehicleType
    {
        Car,
        Lorry,
        Motorcycle
    };

    public partial class VehicleTypeControl : UserControl
    {
        public VehicleType vehicleType { get; set; }
        public VehicleTypeControl()
        {
            InitializeComponent();
            vehicleType = VehicleType.Car;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(vehicleType == VehicleType.Car)
            {
                vehicleType = VehicleType.Lorry;
            }
            else if(vehicleType == VehicleType.Lorry)
            {
                vehicleType = VehicleType.Motorcycle;
            }
            else if(vehicleType == VehicleType.Motorcycle)
            {
                vehicleType = VehicleType.Car;
            }
            UpdateIcon();
        }

        public void UpdateIcon()
        {
            if (vehicleType == VehicleType.Car)
            {
                Button.BackgroundImage = Properties.Resources.car;
            }
            else if (vehicleType == VehicleType.Lorry)
            {
                Button.BackgroundImage = Properties.Resources.lorry;
            }
            else if (vehicleType == VehicleType.Motorcycle)
            {
                Button.BackgroundImage = Properties.Resources.motorcycle;
            }
        }
    }

}
