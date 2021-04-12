using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIApp;

namespace Projekt1
{
    public partial class AddVehicleForm : Form
    {
        public string VehicleBrand
        {
            get { return brand.Text; }
        }

        public int MaxSpeed
        {
            get { int res; return int.TryParse(maxSpeed.Text, out res) ? res : throw new Exception("Error in convertion string to int"); }
        }

        public DateTime ProductionDate
        {
            get { return productionDatePicker.Value; }
        }

        public VehicleType Type
        {
           get { return vehicleTypeControl2.vehicleType; }
        }
        public AddVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            if(vehicle != null)
            {
                brandLabel.Text = vehicle.brand;
                maxSpeed.Text = vehicle.maxSpeed.ToString();
                productionDatePicker.Value = vehicle.prodDate;
                vehicleTypeControl2.vehicleType = vehicle.vehicleType;
                vehicleTypeControl2.UpdateIcon();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void brand_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(brand.Text))
            {
                errorProviderBrand.SetError(brand, "You must type in brand name.");
                e.Cancel = true;
            }
            else
            {
                errorProviderBrand.Clear();
            }
        }

        private void speed_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maxSpeed.Text))
            {
                errorProviderSpeed.SetError(maxSpeed, "You must type in max speed value.");
                e.Cancel = true;
            }
            else
            {
                int res;
                if (!int.TryParse(maxSpeed.Text, out res))
                {
                    errorProviderSpeed.SetError(maxSpeed, "Value should be a integer number");
                    e.Cancel = true;
                }
                else
                {
                    errorProviderSpeed.Clear();
                }
            }
        }
    }
}
