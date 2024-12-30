namespace ParkingReservationApp
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            Reservationbtn = new PictureBox();
            waitingListbtn = new PictureBox();
            Exitbtn = new PictureBox();
            unparkandparkpnl = new Panel();
            label4 = new Label();
            label3 = new Label();
            txtlicense = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RemoveBtn = new PictureBox();
            Addbtn = new PictureBox();
            parkingGridView = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            WaitingPnl = new Panel();
            waitingGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label5 = new Label();
            Searchbtn = new PictureBox();
            SearchTxtBx = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Reservationbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waitingListbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exitbtn).BeginInit();
            unparkandparkpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Addbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parkingGridView).BeginInit();
            WaitingPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)waitingGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Searchbtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Park_unpbtn;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(70, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 40);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Reservationbtn
            // 
            Reservationbtn.BackColor = Color.Transparent;
            Reservationbtn.BackgroundImage = Properties.Resources.Reservation_button;
            Reservationbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Reservationbtn.Location = new Point(79, 220);
            Reservationbtn.Name = "Reservationbtn";
            Reservationbtn.Size = new Size(144, 49);
            Reservationbtn.TabIndex = 4;
            Reservationbtn.TabStop = false;
            Reservationbtn.Click += Reservationbtn_Click;
            // 
            // waitingListbtn
            // 
            waitingListbtn.BackColor = Color.Transparent;
            waitingListbtn.BackgroundImage = Properties.Resources.waiting_list_button;
            waitingListbtn.BackgroundImageLayout = ImageLayout.Zoom;
            waitingListbtn.Location = new Point(79, 275);
            waitingListbtn.Name = "waitingListbtn";
            waitingListbtn.Size = new Size(144, 50);
            waitingListbtn.TabIndex = 5;
            waitingListbtn.TabStop = false;
            waitingListbtn.Click += waitingListbtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.Transparent;
            Exitbtn.BackgroundImage = Properties.Resources.Exitbtn;
            Exitbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Exitbtn.Location = new Point(105, 331);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(91, 45);
            Exitbtn.TabIndex = 6;
            Exitbtn.TabStop = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // unparkandparkpnl
            // 
            unparkandparkpnl.BackColor = Color.Transparent;
            unparkandparkpnl.Controls.Add(label4);
            unparkandparkpnl.Controls.Add(label3);
            unparkandparkpnl.Controls.Add(txtlicense);
            unparkandparkpnl.Controls.Add(label2);
            unparkandparkpnl.Controls.Add(label1);
            unparkandparkpnl.Controls.Add(RemoveBtn);
            unparkandparkpnl.Controls.Add(Addbtn);
            unparkandparkpnl.Controls.Add(parkingGridView);
            unparkandparkpnl.Location = new Point(267, 12);
            unparkandparkpnl.Name = "unparkandparkpnl";
            unparkandparkpnl.Size = new Size(453, 377);
            unparkandparkpnl.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = Properties.Resources.Btn_layout_removebg_preview;
            label4.Location = new Point(268, 346);
            label4.Name = "label4";
            label4.Size = new Size(67, 18);
            label4.TabIndex = 7;
            label4.Text = "Remove";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.Btn_layout_removebg_preview;
            label3.Location = new Point(126, 346);
            label3.Name = "label3";
            label3.Size = new Size(35, 18);
            label3.TabIndex = 6;
            label3.Text = "Add";
            // 
            // txtlicense
            // 
            txtlicense.Location = new Point(21, 306);
            txtlicense.Name = "txtlicense";
            txtlicense.Size = new Size(415, 23);
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
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            RemoveBtn.BackgroundImageLayout = ImageLayout.Zoom;
            RemoveBtn.Location = new Point(237, 330);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(127, 50);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.TabStop = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            Addbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Addbtn.Location = new Point(80, 330);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(127, 50);
            Addbtn.TabIndex = 1;
            Addbtn.TabStop = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // parkingGridView
            // 
            parkingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parkingGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parkingGridView.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8 });
            parkingGridView.Location = new Point(0, 0);
            parkingGridView.Name = "parkingGridView";
            parkingGridView.Size = new Size(452, 300);
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
            // WaitingPnl
            // 
            WaitingPnl.Controls.Add(waitingGridView);
            WaitingPnl.Location = new Point(267, 12);
            WaitingPnl.Name = "WaitingPnl";
            WaitingPnl.Size = new Size(453, 377);
            WaitingPnl.TabIndex = 9;
            // 
            // waitingGridView
            // 
            waitingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            waitingGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            waitingGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            waitingGridView.Location = new Point(0, 0);
            waitingGridView.Name = "waitingGridView";
            waitingGridView.Size = new Size(453, 377);
            waitingGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Position";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "License Plate";
            Column2.Name = "Column2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Searchbtn);
            panel1.Controls.Add(SearchTxtBx);
            panel1.Location = new Point(267, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 380);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = Properties.Resources.Btn_layout_removebg_preview;
            label5.Location = new Point(194, 249);
            label5.Name = "label5";
            label5.Size = new Size(66, 18);
            label5.TabIndex = 2;
            label5.Text = "Search";
            label5.Click += label5_Click;
            // 
            // Searchbtn
            // 
            Searchbtn.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            Searchbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Searchbtn.Location = new Point(147, 217);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(161, 83);
            Searchbtn.TabIndex = 1;
            Searchbtn.TabStop = false;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // SearchTxtBx
            // 
            SearchTxtBx.BackColor = Color.FromArgb(64, 64, 0);
            SearchTxtBx.BorderStyle = BorderStyle.FixedSingle;
            SearchTxtBx.Cursor = Cursors.IBeam;
            SearchTxtBx.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTxtBx.ForeColor = SystemColors.ControlText;
            SearchTxtBx.Location = new Point(33, 143);
            SearchTxtBx.Name = "SearchTxtBx";
            SearchTxtBx.Size = new Size(388, 29);
            SearchTxtBx.TabIndex = 0;
            SearchTxtBx.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(SearchTxtBx, "Enter Licanse Plate");
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(726, 401);
            Controls.Add(panel1);
            Controls.Add(WaitingPnl);
            Controls.Add(unparkandparkpnl);
            Controls.Add(Exitbtn);
            Controls.Add(waitingListbtn);
            Controls.Add(Reservationbtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Reservationbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)waitingListbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exitbtn).EndInit();
            unparkandparkpnl.ResumeLayout(false);
            unparkandparkpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Addbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)parkingGridView).EndInit();
            WaitingPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)waitingGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Searchbtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Reservationbtn;
        private PictureBox waitingListbtn;
        private PictureBox Exitbtn;
        private Panel unparkandparkpnl;
        private TextBox txtlicense;
        private Label label2;
        private Label label1;
        private PictureBox RemoveBtn;
        private PictureBox Addbtn;
        private DataGridView parkingGridView;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label3;
        private Label label4;
        private Panel WaitingPnl;
        private DataGridView waitingGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel1;
        private PictureBox Searchbtn;
        private TextBox SearchTxtBx;
        private Label label5;
        private ToolTip toolTip1;
    }
}