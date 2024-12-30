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
            
            Reservation Reserve = new Reservation();
            this.Hide();
            Reserve.ShowDialog();
        }

        private void Addcustomerbtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}
