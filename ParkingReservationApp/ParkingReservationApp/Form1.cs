namespace ParkingReservationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)//Admin to
        {
            Login log = new Login();
            this.Hide();
            log.Show();
            
        }

        private void Addcustomerbtn_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            this.Hide();
            newform.Show();
        }
    }
}
