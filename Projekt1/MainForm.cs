using MDIApp;
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
    public partial class MainForm : Form
    {
            VehiclesDocument document = new VehiclesDocument();

            public MainForm()
            {
                InitializeComponent();
            }

            private void winowToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void fileToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void toolStripButton1_Click(object sender, EventArgs e)
            {
                VehiclesListForm vehiclesForm = new VehiclesListForm(document);
                vehiclesForm.MdiParent = this;
                vehiclesForm.Show();
            }

            private void toolStripButton2_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void noweOknoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                toolStripButton1_Click(sender, e);
            }
    }
}

