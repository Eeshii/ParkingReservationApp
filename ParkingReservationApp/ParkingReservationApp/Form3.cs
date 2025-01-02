using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace ParkingReservationApp
{
    public partial class Form3 : Form
    {
        private string[] parkingSlots;
        private int parkingLotSize = 10;
        public Form3()
        {
            InitializeComponent();
        }
        public class Reservation
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string CarType { get; set; }
            public string LicenseNumber { get; set; }
            public string ReservationType { get; set; }
            public string DateTime { get; set; }
            public string SlotNumber { get; set; }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string carType = txtCarType.Text;
            string licenseNumber = txtLicense.Text;
            string reservationType = cmbReservationType.SelectedItem?.ToString();
            string dateTime = dtpDateTime.Value.ToString("yyyy-MM-dd HH:mm");
            string slotNumber = cmbSlot.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(carType) || string.IsNullOrWhiteSpace(licenseNumber) || string.IsNullOrWhiteSpace(reservationType) || string.IsNullOrWhiteSpace(slotNumber))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!parkingSlots.Contains(slotNumber))
            {
                MessageBox.Show("Slot is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var reservation = new Reservation
            {
                Name = name,
                Email = email,
                Phone = phone,
                CarType = carType,
                LicenseNumber = licenseNumber,
                ReservationType = reservationType,
                DateTime = dateTime,
                SlotNumber = slotNumber
            };

            SaveReservationToJson(reservation);
            parkingSlots[Array.IndexOf(parkingSlots, slotNumber)] = null; // Mark slot as reserved
            UpdateUI();
            MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtCarType.Clear();
            txtLicense.Clear();
            cmbReservationType.SelectedIndex = -1;
            dtpDateTime.Value = DateTime.Now;
            cmbSlot.SelectedIndex = -1;
        }
        private void SaveReservationToJson(Reservation reservation)
        {
            var filePath = "Parking.json";
            var reservations = new List<Reservation>();

            if (File.Exists(filePath))
            {
                var existingData = File.ReadAllText(filePath);
                reservations = JsonSerializer.Deserialize<List<Reservation>>(existingData) ?? new List<Reservation>();
            }

            reservations.Add(reservation);
            File.WriteAllText(filePath, JsonSerializer.Serialize(reservations, new JsonSerializerOptions { WriteIndented = true }));
        }
        private void LoadData()
        {
            for (int i = 0; i < parkingLotSize; i++)
            {
                parkingSlots[i] = $"Slot {i + 1}";
            }
        }
        private void UpdateUI()
        {
            cmbSlot.Items.Clear();
            cmbSlot.Items.AddRange(parkingSlots.Where(slot => slot != null).ToArray());
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            parkingSlots = new string[parkingLotSize];
            LoadData();
            UpdateUI();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();form2.Show();
        }
    }
}
