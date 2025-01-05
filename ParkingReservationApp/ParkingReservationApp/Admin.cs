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
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using ParkingReservationApp;
using static ParkingReservationApp.Form3;

namespace ParkingReservationApp
{
    public partial class Admin : Form
    {
        public const string StoreData = "Parking.json";
        // parking slot
        private string[] parkingSlots;
        // waiting list
        private Queue<string> waitingQueue = new Queue<string>();
        // history
        private Stack<string> parkingHistory = new Stack<string>();
        // for unique plate numbers
        private HashSet<string> parkedCars = new HashSet<string>();
        // specifying parking lot size
        private int parkingLotSize = 10;


        public Admin()
        {
            InitializeComponent();
            LoadData();
            UpdateAllGrids();
        }
        private List<Form3.Reservation> LoadReservations()

        {
            var file = "Reservation.json";
            var reservations = new List<Form3.Reservation>();

            if (File.Exists(file))
            {
                var json = File.ReadAllText(file);
                reservations = JsonConvert.DeserializeObject<List<Form3.Reservation>>(json) ?? new List<Form3.Reservation>();
            }

            return reservations;
        }
        public class ParkingData
        {
            public string[] ParkingSlots { get; set; }
            public List<string> WaitingQueue { get; set; }
            public List<string> ParkingHistory { get; set; }
            public List<string> ParkedCars { get; set; }
        }

        private void ParkingHistoryBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(historyPanel);
            UpdateHistoryGrid();
        }
        private void LoadData()
        {
            if (File.Exists(StoreData))
            {
                var json = File.ReadAllText(StoreData);
                var data = JsonConvert.DeserializeObject<ParkingData>(json);


                parkingSlots = data.ParkingSlots ?? new string[parkingLotSize];
                waitingQueue = new Queue<string>(data.WaitingQueue ?? new List<string>());
                parkingHistory = new Stack<string>((data.ParkingHistory ?? new List<string>()).AsEnumerable().Reverse());
                parkedCars = new HashSet<string>(data.ParkedCars ?? new List<string>());
            }
            else
            {
                parkingSlots = new string[parkingLotSize];
            }

        }
        private void UpdateHistoryGrid()
        {
            historyGridView.Rows.Clear();

            foreach (var entry in parkingHistory)
            {
                var parts = entry.Split('|');
                if (parts.Length == 3)
                {
                    historyGridView.Rows.Add(parts[0], parts[1], parts[2]);
                }
            }
        }

        private void UpdateAllGrids()
        {
            UpdateHistoryGrid();
            UpdateParkingStatus();
            UpdateReservationGrid();
        }
        private void UpdateParkingStatus()
        {
            waitingGridView.Rows.Clear();
            for (int i = 0; i < parkingSlots.Length; i++)
            {
                string slotStatus = parkingSlots[i] == null ? "Available" : "Occupied";
                string plateNumber = parkingSlots[i] ?? "Empty";
                // adds row to the data grid view
                waitingGridView.Rows.Add($"Slot {i + 1}", plateNumber, slotStatus);
            }
        }
        private void ShowPanel(Panel panelToShow)
        {
            historyPanel.Visible = false;
            panel1.Visible = false;
            reservationPanel.Visible = false;

            panelToShow.Visible = true;
        }
        private void UpdateReservationGrid()
        {
            reservationGridView.Rows.Clear();

            foreach (var reservation in LoadReservations())
            {
                reservationGridView.Rows.Add(reservation.Name, reservation.Email, reservation.Phone, reservation.CarType, reservation.LicenseNumber, reservation.ReservationType, reservation.DateTime, reservation.SlotNumber);
            }
        }

        private void ReservationLstBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(reservationPanel);
            UpdateReservationGrid();
        }

        private void ParkingQBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(panel1);
            UpdateParkingStatus();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();
        }

        private void reservationPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
//panel 2 history
//panel 1 waitingqueue