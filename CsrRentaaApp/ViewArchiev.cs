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
    public partial class ViewArchiev : Form
    {
        private readonly CarRentalEntities _dbView;

        public ViewArchiev()
        {
            InitializeComponent();
            _dbView = new CarRentalEntities();
        }

        private void ViewArchiev_Load(object sender, EventArgs e)
        {
            var cars = _dbView.CarRentalRecords.Select(q => new {id=q.id,CustomerName=q.CustomerName, DateRented=q.DateRented,DateReturned=q.DateReturned,cost=q.Cost,TypeOfCar=q.TypeOfCarId}).ToList();
            gvViewArchiv.DataSource= cars;
            gvViewArchiv.Columns[0].HeaderText = "ID";
            gvViewArchiv.Columns[1].HeaderText = "CUSTOMER NAME";
            gvViewArchiv.Columns[2].HeaderText = "Date Rented";
            gvViewArchiv.Columns[3].HeaderText = "Date Returned";
            gvViewArchiv.Columns[4].HeaderText = "Cost";
            gvViewArchiv.Columns[5].HeaderText = "Types of Car";

        }
    }
}
