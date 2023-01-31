using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsrRentaaApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AddRentalRecord = new AddRentalRecord();
            AddRentalRecord.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Enabled= true;
        }

        private void addRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddRentalRecord();
            addRentalRecord.MdiParent = this;
            addRentalRecord.Show();
        }

        private void viewArchivToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleListing = new ManageVehile_Listing();
            vehicleListing.MdiParent = this;
            vehicleListing.Show();
        }

        private void viewListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleListing = new ManageVehile_Listing();
            vehicleListing.MdiParent = this;
            vehicleListing.Show();
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
