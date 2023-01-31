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
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;


        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet.CarRentalRecord' table. You can move, or remove it, as needed.
            this.carRentalRecordTableAdapter.Fill(this.carRentalDataSet.CarRentalRecord);

            //Select*From TypeOfCars
            var cars = carRentalEntities.TypesOfCars.ToList();
            cbTypeofCar.DisplayMember = "Name";
            cbTypeofCar.ValueMember = "id";
            cbTypeofCar.DataSource = cars;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string customer = tbCustomer.Text;
            var dateOut =  dtpRented.Value;
            var dateIn = dtpReturned.Value;
            double cost = Convert.ToDouble(tbCost.Text);

            var cartype = cbTypeofCar.Text;
            var isValid = true;
                var errorMessage = "";

            if(string.IsNullOrWhiteSpace(customer) || string.IsNullOrWhiteSpace(cartype))
            {
                isValid = false;
                    errorMessage += "Error : Please Enter Missing Date.\n\r";
            }

            if(dateOut > dateIn)
            {
                    isValid = false;
                errorMessage += ("Error : Illegal Date Selection \n\r");
            }


            if(isValid) 
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = customer;
                    rentalRecord.DateRented= dateOut;
                    rentalRecord.DateReturned= dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbTypeofCar.SelectedValue;


                    carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    carRentalEntities.SaveChanges();


                MessageBox.Show($"Customer Name:{customer}\n\r" +
                $"Date Rented:{dateOut}\n\r" +
                $"Date Returned:{dateIn}\n\r" +
                $"Cost: {cost}\n\r" +
                $"Car Type: {cartype}\n\r");
                MessageBox.Show("Tanks YOur for your Buisness");
             }
            else
                {
                    MessageBox.Show(errorMessage);
                }
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
