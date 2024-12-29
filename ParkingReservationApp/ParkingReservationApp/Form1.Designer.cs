namespace ParkingReservationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Loginbtn = new Label();
            Addcustomerbtn = new Label();
            SuspendLayout();
            // 
            // Loginbtn
            // 
            Loginbtn.AutoSize = true;
            Loginbtn.BackColor = Color.Transparent;
            Loginbtn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.ForeColor = SystemColors.ButtonHighlight;
            Loginbtn.Location = new Point(261, 331);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(69, 22);
            Loginbtn.TabIndex = 0;
            Loginbtn.Text = "Admin";
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Addcustomerbtn
            // 
            Addcustomerbtn.AutoSize = true;
            Addcustomerbtn.BackColor = Color.Transparent;
            Addcustomerbtn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addcustomerbtn.ForeColor = SystemColors.ButtonHighlight;
            Addcustomerbtn.Location = new Point(78, 331);
            Addcustomerbtn.Name = "Addcustomerbtn";
            Addcustomerbtn.Size = new Size(101, 22);
            Addcustomerbtn.TabIndex = 1;
            Addcustomerbtn.Text = "Customer";
            Addcustomerbtn.Click += Addcustomerbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Form1design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(746, 430);
            Controls.Add(Addcustomerbtn);
            Controls.Add(Loginbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Loginbtn;
        private Label Addcustomerbtn;
    }
}
