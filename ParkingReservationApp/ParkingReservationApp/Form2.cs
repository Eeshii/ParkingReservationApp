using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParkingReservationApp.Reservation;

namespace ParkingReservationApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void ParkCar(string plateNumber)
        {
            string timeFormat = "HH/mm";
            if (string.IsNullOrWhiteSpace(plateNumber))
            {
                MessageBox.Show("Please enter a valid license plate.");
                return;
            }
            if (parkedCars.Contains(plateNumber))
            {
                MessageBox.Show("This car is already parked.");
                return;
            }
            // searches for an empty slot
            for (int i = 0; i < parkingSlots.Length; i++)
            {
                if (parkingSlots[i] == null)
                {
                    parkingSlots[i] = plateNumber;
                    parkedCars.Add(plateNumber);
                    UpdateUI();
                    return;

                }
            }
            // add to waiting list
            waitingQueue.Enqueue(plateNumber);
            MessageBox.Show("Parking lot is full. Added to the waiting list.");
            Save_Data();
            UpdateUI();
        }
        private void UnparkCar(string plateNumber)
        {
            string timeFormat = "HH/mm";
            if (!parkedCars.Contains(plateNumber))
            {
                MessageBox.Show("Car not found in the parking lot.");
                return;
            }
            // unpark
            for (int i = 0; i < parkingSlots.Length; i++)
            {
                if (parkingSlots[i] == plateNumber)
                {
                    parkingSlots[i] = null;
                    parkedCars.Remove(plateNumber);
                    
                    MessageBox.Show($"Car {plateNumber} has been removed.");
                    break;
                }
            }
            // moves car from waiting list to the parking lot
            if (waitingQueue.Count > 0)
            {
                string nextCar = waitingQueue.Dequeue();
                for (int i = 0; i < parkingSlots.Length; i++)
                {
                    if (parkingSlots[i] == null)
                    {
                        parkingSlots[i] = nextCar;
                        parkedCars.Add(nextCar);
                       
                        MessageBox.Show($"Car {nextCar} has been parked from the waiting list.");

                        break;
                    }
                }
            }
            Save_Data();
            UpdateUI();

        }
        private void UpdateWaitingList()
        {
            waitingGridView.Rows.Clear();

            int position = 1;
            foreach (string plateNumber in waitingQueue)
            {
                waitingGridView.Rows.Add(position++, plateNumber);
            }
        }
        private void UpdateParkingStatus()
        {
            parkingGridView.Rows.Clear();
            for (int i = 0; i < parkingSlots.Length; i++)
            {
                string slotStatus = parkingSlots[i] == null ? "Available" : "Occupied";
                string plateNumber = parkingSlots[i] ?? "Empty";
                // adds row to the data grid view
                parkingGridView.Rows.Add($"Slot {i + 1}", plateNumber, slotStatus);
            }
        }
        private void UpdateUI()
        {
            UpdateParkingStatus();
            UpdateWaitingList();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//Park UnparkBtn
        {

        }

        private void Reservationbtn_Click(object sender, EventArgs e)
        {

        }

        private void waitingListbtn_Click(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {

        }
        private void ReserveSlot(string plateNumber)
        {
            string timeFormat = "HH/mm";
            if (string.IsNullOrWhiteSpace(plateNumber))
            {
                MessageBox.Show("Please enter a valid license plate.");
                return;
            }
            if (parkedCars.Contains(plateNumber))
            {
                MessageBox.Show("This car is already parked.");
                return;
            }

            for (int i = 0; i < parkingSlots.Length; i++)
            {
                if (parkingSlots[i] == null) 
                {
                    parkingSlots[i] = plateNumber;
                    parkedCars.Add(plateNumber);
                    parkingHistory.Push($"Reserved|{plateNumber}|{DateTime.Now.ToString(timeFormat)}");
                    MessageBox.Show($"Car {plateNumber} has been parked in Slot {i + 1} (reserved).");
                    UpdateUI();
                    return;
                }
            }

            waitingQueue.Enqueue(plateNumber);
            MessageBox.Show("Parking lot is full. Added to the waiting list with priority.");
            UpdateUI();
        }
        private void Save_Data()
        {
            var data = new ParkingData
            {
                ParkingSlots = parkingSlots,
                WaitingQueue = waitingQueue.ToList(),
                ParkingHistory = parkingHistory.ToList(),
                ParkedCars = parkedCars.ToList(),
            };
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(StoreData, json);
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

                UpdateUI();
            }
            else
            {
                parkingSlots = new string[parkingLotSize];
            }

        }
    }
}
