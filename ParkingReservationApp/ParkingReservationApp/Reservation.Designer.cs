namespace ParkingReservationApp
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            pictureBox1 = new PictureBox();
            Exitbtn = new PictureBox();
            Historybtn = new PictureBox();
            Reservationbtn = new PictureBox();
            waitingListbtn = new PictureBox();
            panel1 = new Panel();
            waitingGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            historyGridView = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            txtlicense = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RemoveBtn = new PictureBox();
            Addbtn = new PictureBox();
            parkingGridView = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exitbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Historybtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Reservationbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waitingListbtn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)waitingGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyGridView).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Addbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parkingGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Park_unpbtn;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(612, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 40);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.Transparent;
            Exitbtn.BackgroundImage = Properties.Resources.Exitbtn;
            Exitbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Exitbtn.Location = new Point(634, 397);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(119, 36);
            Exitbtn.TabIndex = 1;
            Exitbtn.TabStop = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // Historybtn
            // 
            Historybtn.BackColor = Color.Transparent;
            Historybtn.BackgroundImage = Properties.Resources.history_button;
            Historybtn.BackgroundImageLayout = ImageLayout.Zoom;
            Historybtn.Location = new Point(622, 339);
            Historybtn.Name = "Historybtn";
            Historybtn.Size = new Size(144, 43);
            Historybtn.TabIndex = 2;
            Historybtn.TabStop = false;
            Historybtn.Click += Historybtn_Click;
            // 
            // Reservationbtn
            // 
            Reservationbtn.BackColor = Color.Transparent;
            Reservationbtn.BackgroundImage = Properties.Resources.Reservation_button;
            Reservationbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Reservationbtn.Location = new Point(625, 228);
            Reservationbtn.Name = "Reservationbtn";
            Reservationbtn.Size = new Size(144, 49);
            Reservationbtn.TabIndex = 3;
            Reservationbtn.TabStop = false;
            Reservationbtn.Click += Reservationbtn_Click;
            // 
            // waitingListbtn
            // 
            waitingListbtn.BackColor = Color.Transparent;
            waitingListbtn.BackgroundImage = Properties.Resources.waiting_list_button;
            waitingListbtn.BackgroundImageLayout = ImageLayout.Zoom;
            waitingListbtn.Location = new Point(622, 283);
            waitingListbtn.Name = "waitingListbtn";
            waitingListbtn.Size = new Size(144, 50);
            waitingListbtn.TabIndex = 4;
            waitingListbtn.TabStop = false;
            waitingListbtn.Click += waitingListbtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(waitingGridView);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 419);
            panel1.TabIndex = 5;
            // 
            // waitingGridView
            // 
            waitingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            waitingGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            waitingGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            waitingGridView.Location = new Point(0, 0);
            waitingGridView.Name = "waitingGridView";
            waitingGridView.Size = new Size(501, 421);
            waitingGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Position Queue";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "License Plate";
            Column2.Name = "Column2";
            // 
            // panel2
            // 
            panel2.Controls.Add(historyGridView);
            panel2.Location = new Point(23, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 419);
            panel2.TabIndex = 6;
            // 
            // historyGridView
            // 
            historyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyGridView.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5 });
            historyGridView.Location = new Point(16, 22);
            historyGridView.Name = "historyGridView";
            historyGridView.Size = new Size(488, 397);
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
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(txtlicense);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(RemoveBtn);
            panel3.Controls.Add(Addbtn);
            panel3.Controls.Add(parkingGridView);
            panel3.Location = new Point(23, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 421);
            panel3.TabIndex = 8;
            // 
            // txtlicense
            // 
            txtlicense.Location = new Point(23, 334);
            txtlicense.Name = "txtlicense";
            txtlicense.Size = new Size(458, 23);
            txtlicense.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.Btn_layout_removebg_preview;
            label2.Location = new Point(284, 383);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 4;
            label2.Text = "Remove";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.Btn_layout_removebg_preview;
            label1.Location = new Point(147, 383);
            label1.Name = "label1";
            label1.Size = new Size(35, 18);
            label1.TabIndex = 3;
            label1.Text = "Add";
            label1.Click += label1_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            RemoveBtn.BackgroundImageLayout = ImageLayout.Zoom;
            RemoveBtn.Location = new Point(252, 366);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(127, 50);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.TabStop = false;
            // 
            // Addbtn
            // 
            Addbtn.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            Addbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Addbtn.Location = new Point(102, 366);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(127, 50);
            Addbtn.TabIndex = 1;
            Addbtn.TabStop = false;
            // 
            // parkingGridView
            // 
            parkingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parkingGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parkingGridView.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8 });
            parkingGridView.Location = new Point(23, 29);
            parkingGridView.Name = "parkingGridView";
            parkingGridView.Size = new Size(481, 295);
            parkingGridView.TabIndex = 0;
            // 
            // Column6
            // 
            Column6.HeaderText = "Slot";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "License Plate";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Status";
            Column8.Name = "Column8";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(459, 407);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 455);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(waitingListbtn);
            Controls.Add(Reservationbtn);
            Controls.Add(Historybtn);
            Controls.Add(Exitbtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reservation";
            Text = "Reservation";
            Load += Reservation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exitbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Historybtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Reservationbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)waitingListbtn).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)waitingGridView).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Addbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)parkingGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Exitbtn;
        private PictureBox Historybtn;
        private PictureBox Reservationbtn;
        private PictureBox waitingListbtn;
        private Panel panel1;
        private DataGridView waitingGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel2;
        private DataGridView historyGridView;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel3;
        private TextBox txtlicense;
        private Label label2;
        private Label label1;
        private PictureBox RemoveBtn;
        private PictureBox Addbtn;
        private DataGridView parkingGridView;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private PictureBox pictureBox2;
    }
}