using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnSimpsonProject1
{
    public partial class AddCarForm : Form
    {
        public Car NewCar { get;private set; }
        
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddVehicleToLot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MakeTextBox.Text))
            {
                MessageBox.Show("Please Enter valid Make");
            }
           
            if (string.IsNullOrWhiteSpace(ModelTextBox.Text))
            {
                MessageBox.Show("Please enter valid Model");
            }

            if ((double.TryParse(MpgTextBox.Text, out double mpg)) && (decimal.TryParse(PriceTextBox.Text, out decimal price)))
            {
                var make = MakeTextBox.Text;
                var model = ModelTextBox.Text;
                
                NewCar = new Car(make, model, mpg, price);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please make sure you entered valid numbers for price and MPG");
            }
            


        }
    }
}
