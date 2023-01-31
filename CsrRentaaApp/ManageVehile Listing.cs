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
    public partial class ManageVehile_Listing : Form
    {

        private readonly CarRentalEntities _db;
        public ManageVehile_Listing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehile_Listing_Load(object sender, EventArgs e)
        {
            //Selectz * From TypeOFCars
            //var cars = _db.TypesOfCars.ToList();

            var cars = _db.TypesOfCars.Select(q => new { CarId = q.id,CarName = q.name }).ToList();


            gvVehicleList.DataSource= cars;
            gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[1].HeaderText = "NAME";



        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }
    }
}
