namespace ParkingReservationApp
{
    partial class Form3
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtCarType = new TextBox();
            txtLicense = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbReservationType = new ComboBox();
            cmbSlot = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            SaveBtn = new Label();
            Exitbtn = new Label();
            dtpDateTime = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(117, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(426, 27);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(117, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(426, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(188, 103);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(355, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtCarType
            // 
            txtCarType.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCarType.Location = new Point(131, 136);
            txtCarType.Name = "txtCarType";
            txtCarType.Size = new Size(412, 27);
            txtCarType.TabIndex = 3;
            // 
            // txtLicense
            // 
            txtLicense.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLicense.Location = new Point(188, 167);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(355, 27);
            txtLicense.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 26);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(33, 71);
            label2.Name = "label2";
            label2.Size = new Size(65, 26);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 104);
            label3.Name = "label3";
            label3.Size = new Size(149, 26);
            label3.TabIndex = 8;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 137);
            label4.Name = "label4";
            label4.Size = new Size(92, 26);
            label4.TabIndex = 9;
            label4.Text = "Car Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(33, 170);
            label5.Name = "label5";
            label5.Size = new Size(158, 26);
            label5.TabIndex = 10;
            label5.Text = "License Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(33, 249);
            label6.Name = "label6";
            label6.Size = new Size(147, 26);
            label6.TabIndex = 11;
            label6.Text = "Time And Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(33, 209);
            label7.Name = "label7";
            label7.Size = new Size(167, 26);
            label7.TabIndex = 12;
            label7.Text = "Reservation Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(33, 288);
            label8.Name = "label8";
            label8.Size = new Size(127, 26);
            label8.TabIndex = 16;
            label8.Text = "Slot Number:";
            // 
            // cmbReservationType
            // 
            cmbReservationType.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            cmbReservationType.FormattingEnabled = true;
            cmbReservationType.Items.AddRange(new object[] { "PWD", "Pregnant", "Senior Citizen" });
            cmbReservationType.Location = new Point(206, 206);
            cmbReservationType.Name = "cmbReservationType";
            cmbReservationType.Size = new Size(337, 34);
            cmbReservationType.TabIndex = 19;
            // 
            // cmbSlot
            // 
            cmbSlot.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            cmbSlot.FormattingEnabled = true;
            cmbSlot.Items.AddRange(new object[] { "PWD", "Pregnant", "Senior Citizen" });
            cmbSlot.Location = new Point(178, 285);
            cmbSlot.Name = "cmbSlot";
            cmbSlot.Size = new Size(337, 34);
            cmbSlot.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(563, 314);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 81);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(563, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 81);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = true;
            SaveBtn.BackColor = Color.Transparent;
            SaveBtn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = SystemColors.ButtonHighlight;
            SaveBtn.Image = Properties.Resources.Btn_layout_removebg_preview;
            SaveBtn.Location = new Point(609, 252);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(53, 26);
            SaveBtn.TabIndex = 23;
            SaveBtn.Text = "Save";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.AutoSize = true;
            Exitbtn.BackColor = Color.Transparent;
            Exitbtn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exitbtn.ForeColor = SystemColors.ButtonHighlight;
            Exitbtn.Image = Properties.Resources.Btn_layout_removebg_preview;
            Exitbtn.Location = new Point(618, 341);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(44, 26);
            Exitbtn.TabIndex = 24;
            Exitbtn.Text = "Exit";
            Exitbtn.Click += Exitbtn_Click;
            // 
            // dtpDateTime
            // 
            dtpDateTime.CalendarForeColor = Color.Transparent;
            dtpDateTime.CalendarMonthBackground = Color.Transparent;
            dtpDateTime.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            dtpDateTime.Location = new Point(186, 246);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.Size = new Size(329, 33);
            dtpDateTime.TabIndex = 25;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.REservationDesign_;
            ClientSize = new Size(721, 407);
            Controls.Add(dtpDateTime);
            Controls.Add(Exitbtn);
            Controls.Add(SaveBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cmbSlot);
            Controls.Add(cmbReservationType);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLicense);
            Controls.Add(txtCarType);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtCarType;
        private TextBox txtLicense;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbReservationType;
        private ComboBox cmbSlot;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label SaveBtn;
        private Label Exitbtn;
        private DateTimePicker dtpDateTime;
    }
}