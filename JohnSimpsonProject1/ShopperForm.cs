using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JohnSimpsonProject1
{
    public partial class ShopperForm : Form
    {
        //public Shopper Shopper1 { get; private set; }
        public Shopper Shopper { get; set; } = null!;

        public ShopperForm()
        {
            InitializeComponent();
        }

        private void ShopperNameBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ShopperNameBox.Text))
            {
                MessageBox.Show(@"Please enter a valid name");
                return;
            }

            if (decimal.TryParse(ShopperBudgetBox.Text, out var budget))
            {
                var name = ShopperNameBox.Text;
                Shopper = new Shopper(name, budget);
                
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(@"Please enter valid number");
            }
        }
    }
}
