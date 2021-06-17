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
    public partial class VehiclesListForm : Form
    {
        private VehiclesDocument Document { get; }

        public VehiclesListForm(VehiclesDocument document)
        {
            Document = document;
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicleForm vehicleForm = new AddVehicleForm(null);
            if (vehicleForm.ShowDialog() == DialogResult.OK)
            {
                Vehicle newVehicle = new Vehicle(vehicleForm.VehicleBrand, vehicleForm.MaxSpeed, vehicleForm.ProductionDate, vehicleForm.Type);

                Document.AddVehicle(newVehicle);

            }
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            UpdateItems();
            Document.AddVehicleEvent += Document_AddVehicleEvent;
            Document.UpdateVehicleEvent += Document_UpdateVehicleEvent;
            Document.RemoveVehicleEvent += Document_RemoveVehicleEvent;
            UpdateCommandAvailability();

        }

        private void UpdateCommandAvailability()
        {
            editToolStripMenuItem.Enabled = VehiclesListView.SelectedItems.Count == 1;
            toolStripButtonDelete.Enabled = VehiclesListView.SelectedItems.Count > 0;
            toolStripButtonEdit.Enabled = VehiclesListView.SelectedItems.Count == 1;
            removeToolStripMenuItem.Enabled = VehiclesListView.SelectedItems.Count > 0;
            toolStripButtonEdit.Enabled = VehiclesListView.SelectedItems.Count == 1;
            ToolStripMenuItemDelete.Enabled = VehiclesListView.SelectedItems.Count > 0;
        }

        private void Document_RemoveVehicleEvent(Vehicle obj)
        {
            foreach (ListViewItem item in VehiclesListView.Items)
            {
                if (ReferenceEquals(item.Tag, obj))
                {
                    VehiclesListView.Items.Remove(item);
                    UpdateVehicleCount();
                    return;
                }
            }
        }

        private void Document_UpdateVehicleEvent(Vehicle obj)
        {
            foreach (ListViewItem item in VehiclesListView.Items)
            {
                if (ReferenceEquals(item.Tag, obj))
                {
                    if (isVehicleVisible(obj))
                    {
                        UpdateItem(item);
                    }
                    else
                    {
                        VehiclesListView.Items.Remove(item);
                        UpdateVehicleCount();
                    }
                    return;
                }
            }
            Document_AddVehicleEvent(obj);
        }

        private bool isVehicleVisible(Vehicle vehicle)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                return true;
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                return vehicle.maxSpeed < 100;
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                return vehicle.maxSpeed >= 100;
            }
            else
            {
                throw new Exception("Invalid filter");
            }
        }

        private void Document_AddVehicleEvent(Vehicle obj)
        {
            if (isVehicleVisible(obj))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = obj;
                UpdateItem(item);
                VehiclesListView.Items.Add(item);
                UpdateVehicleCount();
            }
        }

        private void UpdateVehicleCount()
        {
            CountVehicles.Text = VehiclesListView.Items.Count.ToString();
        }

        private void UpdateItem(ListViewItem item)
        {
            Vehicle vehicle = (Vehicle)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = vehicle.vehicleType.ToString();
            item.SubItems[1].Text = vehicle.brand.ToString();
            item.SubItems[2].Text = vehicle.maxSpeed.ToString();
            item.SubItems[3].Text = vehicle.prodDate.ToString();
        }

        private void UpdateItems()
        {
            VehiclesListView.Items.Clear();
            foreach (Vehicle vehicle in Document.vehicles)
            {
                if (isVehicleVisible(vehicle))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = vehicle;
                    UpdateItem(item);
                    VehiclesListView.Items.Add(item);
                }
            }
            UpdateVehicleCount();
        }

        private void VehiclesForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip1, ((MainForm)MdiParent).toolStrip1);
        }

        private void VehiclesForm_Deactivated(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).toolStrip1, toolStrip1);
        }

        private void VehiclesForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandAvailability();
        }

        private void Filter_change(object sender, EventArgs e)
        {
            UpdateItems();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in VehiclesListView.SelectedItems)
            {
                for (int i = Document.vehicles.Count - 1; i >= 0; i--)
                {
                    if (ReferenceEquals(item.Tag, Document.vehicles[i]))
                    {
                        Document.RemoveVehicle(Document.vehicles[i]);
                    }
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            removeToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            ListViewItem item = VehiclesListView.SelectedItems[0];
            Vehicle vehicle = (Vehicle)item.Tag;
            AddVehicleForm vehicleForm = new AddVehicleForm(vehicle);
            if (vehicleForm.ShowDialog() == DialogResult.OK)
            {
                vehicle.brand = vehicleForm.VehicleBrand;
                vehicle.maxSpeed = vehicleForm.MaxSpeed;
                vehicle.prodDate = vehicleForm.ProductionDate;
                vehicle.vehicleType = vehicleForm.Type;
                Document.UpdateVehicle(vehicle);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonEdit_Click(sender, e);
        }
    }
}
