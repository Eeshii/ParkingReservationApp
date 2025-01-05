namespace ParkingReservationApp
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ParkingHistoryBtn = new PictureBox();
            ReservationLstBtn = new PictureBox();
            ParkingQBtn = new PictureBox();
            ExitBtn = new PictureBox();
            historyPanel = new Panel();
            historyGridView = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            reservationPanel = new Panel();
            reservationGridView = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            waitingGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ParkingHistoryBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReservationLstBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ParkingQBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyGridView).BeginInit();
            reservationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)waitingGridView).BeginInit();
            SuspendLayout();
            // 
            // ParkingHistoryBtn
            // 
            ParkingHistoryBtn.BackColor = Color.Transparent;
            ParkingHistoryBtn.Location = new Point(515, 170);
            ParkingHistoryBtn.Name = "ParkingHistoryBtn";
            ParkingHistoryBtn.Size = new Size(186, 50);
            ParkingHistoryBtn.TabIndex = 0;
            ParkingHistoryBtn.TabStop = false;
            ParkingHistoryBtn.Click += ParkingHistoryBtn_Click;
            // 
            // ReservationLstBtn
            // 
            ReservationLstBtn.BackColor = Color.Transparent;
            ReservationLstBtn.Location = new Point(515, 226);
            ReservationLstBtn.Name = "ReservationLstBtn";
            ReservationLstBtn.Size = new Size(186, 50);
            ReservationLstBtn.TabIndex = 1;
            ReservationLstBtn.TabStop = false;
            ReservationLstBtn.Click += ReservationLstBtn_Click;
            // 
            // ParkingQBtn
            // 
            ParkingQBtn.BackColor = Color.Transparent;
            ParkingQBtn.Location = new Point(515, 275);
            ParkingQBtn.Name = "ParkingQBtn";
            ParkingQBtn.Size = new Size(186, 53);
            ParkingQBtn.TabIndex = 2;
            ParkingQBtn.TabStop = false;
            ParkingQBtn.Click += ParkingQBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.Location = new Point(515, 334);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(186, 46);
            ExitBtn.TabIndex = 3;
            ExitBtn.TabStop = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // historyPanel
            // 
            historyPanel.BackColor = Color.Transparent;
            historyPanel.Controls.Add(historyGridView);
            historyPanel.Location = new Point(8, 3);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(474, 377);
            historyPanel.TabIndex = 7;
            // 
            // historyGridView
            // 
            historyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyGridView.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5 });
            historyGridView.Location = new Point(4, 0);
            historyGridView.Name = "historyGridView";
            historyGridView.Size = new Size(467, 374);
            historyGridView.TabIndex = 0;
            // 
            // Column3
            // 
            Column3.HeaderText = "Action";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "License Plate";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Time";
            Column5.Name = "Column5";
            // 
            // reservationPanel
            // 
            reservationPanel.BackColor = Color.Transparent;
            reservationPanel.Controls.Add(reservationGridView);
            reservationPanel.Location = new Point(8, 3);
            reservationPanel.Name = "reservationPanel";
            reservationPanel.Size = new Size(474, 377);
            reservationPanel.TabIndex = 8;
            reservationPanel.Paint += reservationPanel_Paint;
            // 
            // reservationGridView
            // 
            reservationGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationGridView.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14 });
            reservationGridView.Location = new Point(0, 3);
            reservationGridView.Name = "reservationGridView";
            reservationGridView.Size = new Size(471, 374);
            reservationGridView.TabIndex = 0;
            // 
            // Column7
            // 
            Column7.HeaderText = "Name";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Email";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Phone";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "CarType";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "License number";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Reservation Type";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Date Time";
            Column13.Name = "Column13";
            // 
            // Column14
            // 
            Column14.HeaderText = "Slot number";
            Column14.Name = "Column14";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(waitingGridView);
            panel1.Location = new Point(8, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 377);
            panel1.TabIndex = 9;
            // 
            // waitingGridView
            // 
            waitingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            waitingGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            waitingGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6 });
            waitingGridView.Location = new Point(3, 4);
            waitingGridView.Name = "waitingGridView";
            waitingGridView.Size = new Size(468, 368);
            waitingGridView.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Slot ";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "License Plate";
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminDesignfnl;
            ClientSize = new Size(725, 408);
            Controls.Add(panel1);
            Controls.Add(reservationPanel);
            Controls.Add(historyPanel);
            Controls.Add(ExitBtn);
            Controls.Add(ParkingQBtn);
            Controls.Add(ReservationLstBtn);
            Controls.Add(ParkingHistoryBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)ParkingHistoryBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReservationLstBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ParkingQBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            historyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyGridView).EndInit();
            reservationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reservationGridView).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)waitingGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ParkingHistoryBtn;
        private PictureBox ReservationLstBtn;
        private PictureBox ParkingQBtn;
        private PictureBox ExitBtn;
        private Panel historyPanel;
        private DataGridView historyGridView;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel reservationPanel;
        private DataGridView reservationGridView;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Panel panel1;
        private DataGridView waitingGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
    }
}