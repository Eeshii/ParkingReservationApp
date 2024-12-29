﻿namespace ParkingReservationApp
{
    partial class Login
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
            UserText = new TextBox();
            PassText = new TextBox();
            LoginBTn = new Label();
            ExitBtn = new Label();
            SuspendLayout();
            // 
            // UserText
            // 
            UserText.BackColor = Color.FromArgb(64, 64, 0);
            UserText.BorderStyle = BorderStyle.None;
            UserText.Location = new Point(455, 115);
            UserText.Name = "UserText";
            UserText.Size = new Size(233, 16);
            UserText.TabIndex = 0;
            // 
            // PassText
            // 
            PassText.BackColor = Color.FromArgb(64, 64, 0);
            PassText.BorderStyle = BorderStyle.None;
            PassText.Location = new Point(455, 146);
            PassText.Name = "PassText";
            PassText.Size = new Size(233, 16);
            PassText.TabIndex = 1;
            // 
            // LoginBTn
            // 
            LoginBTn.AutoSize = true;
            LoginBTn.BackColor = Color.Transparent;
            LoginBTn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBTn.ForeColor = SystemColors.ButtonHighlight;
            LoginBTn.Location = new Point(484, 204);
            LoginBTn.Name = "LoginBTn";
            LoginBTn.Size = new Size(60, 22);
            LoginBTn.TabIndex = 2;
            LoginBTn.Text = "Login";
            LoginBTn.Click += LoginBTn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.AutoSize = true;
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.ButtonHighlight;
            ExitBtn.Location = new Point(615, 204);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(45, 22);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Logindesign;
            ClientSize = new Size(724, 407);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBTn);
            Controls.Add(PassText);
            Controls.Add(UserText);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserText;
        private TextBox PassText;
        private Label LoginBTn;
        private Label ExitBtn;
    }
}