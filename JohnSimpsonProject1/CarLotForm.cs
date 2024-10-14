using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnSimpsonProject1
{
    public partial class CarLotForm : Form
    {
        private CarLot carLot = new CarLot();
        private Shopper shopper;

        public CarLotForm()
        {
            InitializeComponent();
            carLot = new CarLot();
            DisplayInventoryOnLaunch();
        }

        private void DisplayInventoryOnLaunch()
        {
            MainDisplay.Items.Clear();
            foreach (var car in carLot.Inventory)
            {
                MainDisplay.Items.Add($"{car.Make} {car.Model} {car.Price.ToString("C",CultureInfo.CurrentCulture)} {car.Mpg}mpg");
            }
        }

        private void AddVehicleToLot_Click(object sender, EventArgs e)
        {
            using (AddCarForm frm = new AddCarForm())
            {
                //frm.ShowDialog();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    carLot.AddCar(frm.NewCar);
                    DisplayInventoryOnLaunch();
                }
                
            }
        }

        private void RefreshCarLot_Click(object sender, EventArgs e)
        {
            DisplayInventoryOnLaunch();
        }
    }
}
