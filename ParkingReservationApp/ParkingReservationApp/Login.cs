using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingReservationApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();
        }

        private void LoginBTn_Click(object sender, EventArgs e)
        {
            Reservation troll = new Reservation();
            string TextBxUN = UserText.Text;
            string TextBxPW = PassText.Text;
            if (string.IsNullOrWhiteSpace(TextBxUN) || string.IsNullOrWhiteSpace(TextBxPW))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }
            if (TextBxUN == "Admin" && TextBxPW == "Nigga")
            {
                this.Close();
                troll.Show();

            }
            else { MessageBox.Show("Login failed!!"); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PassText.PasswordChar == '•')
            {
                PassText.PasswordChar = '\0'; 
            }
            else
            {
                PassText.PasswordChar = '•'; 
            }
        }
    }
}
