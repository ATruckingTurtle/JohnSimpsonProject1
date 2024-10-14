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
        private readonly CarLot _carLot;
        private Shopper _shopper = null!;

        public CarLotForm()
        {
            InitializeComponent();
            _carLot = new CarLot();
            DisplayInventoryOnLaunch();
        }

        private void DisplayInventoryOnLaunch()
        {
            MainDisplay.Items.Clear();
            foreach (var car in _carLot.Inventory)
            {
                MainDisplay.Items.Add($"{car.Make} {car.Model} {car.Price.ToString("C", CultureInfo.CurrentCulture)} {car.Mpg}mpg");
            }
        }

        private void AddVehicleToLot_Click(object sender, EventArgs e)
        {
            using AddCarForm frm = new AddCarForm();
            //frm.ShowDialog();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _carLot.AddCar(frm.NewCar);
                DisplayInventoryOnLaunch();
            }
        }

        private void RefreshCarLot_Click(object sender, EventArgs e)
        {
            DisplayInventoryOnLaunch();
        }

        private void addShopper_Click(object sender, EventArgs e)
        {
            using ShopperForm shopperForm = new ShopperForm();
            if (shopperForm.ShowDialog() != DialogResult.OK) return;
            _shopper = shopperForm.Shopper;
            ShopperBudget.Text = _shopper.MoneyAvailable.ToString("C",CultureInfo.CurrentCulture);
            ShopperName.Text = _shopper.Name;
            ShopperBudget.Items.Clear();
            ShopperName.Items.Clear();
            ShopperBudget.Items.Add(_shopper.MoneyAvailable.ToString("C", CultureInfo.CurrentCulture));
            ShopperName.Items.Add(_shopper.Name);
        }
    }
}
