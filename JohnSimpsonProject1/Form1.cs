namespace JohnSimpsonProject1
{
    public partial class Form1 : Form
    {
        private CarLotForm? _newCarLotForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarLotAccess_Click(object sender, EventArgs e)
        {
            _newCarLotForm = new CarLotForm();
            _newCarLotForm.ShowDialog();
        }
    }
}
