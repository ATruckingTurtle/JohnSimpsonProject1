namespace JohnSimpsonProject1
{
    public partial class Form1 : Form
    {
        private CarLotForm newCarLotForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarLotAccess_Click(object sender, EventArgs e)
        {
            newCarLotForm = new CarLotForm();
            newCarLotForm.ShowDialog();
        }
    }
}
