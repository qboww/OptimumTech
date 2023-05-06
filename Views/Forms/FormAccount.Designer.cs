using Optimum_Tech.Views.Resources;

namespace Optimum_Tech.Forms
{
    partial class FormAccount
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
            panel1 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            textBoxStatus = new TextBox();
            textBoxAccountPrefferences = new TextBox();
            panel2 = new Panel();
            textBoxLogout = new TextBox();
            pictureBoxLogout = new PictureBox();
            panel4 = new Panel();
            textBoxLogin = new TextBox();
            pictureBoxLogin = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 28);
            panel3.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(63, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 5;
            textBox1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = FormsMedia.register;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBoxRegister_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxStatus);
            panel5.Controls.Add(textBoxAccountPrefferences);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 34);
            panel5.TabIndex = 7;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxStatus.BackColor = Color.FromArgb(30, 30, 30);
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStatus.ForeColor = Color.White;
            textBoxStatus.Location = new Point(509, 3);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(279, 28);
            textBoxStatus.TabIndex = 6;
            textBoxStatus.Text = "Status: Unlogged";
            textBoxStatus.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxAccountPrefferences
            // 
            textBoxAccountPrefferences.BackColor = Color.FromArgb(30, 30, 30);
            textBoxAccountPrefferences.BorderStyle = BorderStyle.None;
            textBoxAccountPrefferences.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountPrefferences.ForeColor = Color.White;
            textBoxAccountPrefferences.Location = new Point(12, 3);
            textBoxAccountPrefferences.Name = "textBoxAccountPrefferences";
            textBoxAccountPrefferences.ReadOnly = true;
            textBoxAccountPrefferences.Size = new Size(245, 28);
            textBoxAccountPrefferences.TabIndex = 4;
            textBoxAccountPrefferences.Text = "Account Prefferences";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            panel2.Controls.Add(textBoxLogout);
            panel2.Controls.Add(pictureBoxLogout);
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 28);
            panel2.TabIndex = 7;
            // 
            // textBoxLogout
            // 
            textBoxLogout.BackColor = Color.FromArgb(30, 30, 30);
            textBoxLogout.BorderStyle = BorderStyle.None;
            textBoxLogout.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogout.ForeColor = Color.White;
            textBoxLogout.Location = new Point(63, 1);
            textBoxLogout.Name = "textBoxLogout";
            textBoxLogout.Size = new Size(100, 24);
            textBoxLogout.TabIndex = 5;
            textBoxLogout.Text = "Logout";
            // 
            // pictureBoxLogout
            // 
            pictureBoxLogout.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLogout.Image = FormsMedia.logout_light;
            pictureBoxLogout.Location = new Point(12, 0);
            pictureBoxLogout.Name = "pictureBoxLogout";
            pictureBoxLogout.Size = new Size(45, 28);
            pictureBoxLogout.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogout.TabIndex = 1;
            pictureBoxLogout.TabStop = false;
            pictureBoxLogout.Click += pictureBoxLogout_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(30, 30, 30);
            panel4.Controls.Add(textBoxLogin);
            panel4.Controls.Add(pictureBoxLogin);
            panel4.Location = new Point(0, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 28);
            panel4.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(30, 30, 30);
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.White;
            textBoxLogin.Location = new Point(63, 1);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(100, 24);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.Text = "Login";
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLogin.Image = FormsMedia.login_light;
            pictureBoxLogin.Location = new Point(12, 0);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(45, 28);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            pictureBoxLogin.Click += pictureBoxLogin_Click;
            // 
            // FormAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAccount";
            Text = "FormAccount";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxLogout;
        private PictureBox pictureBoxLogout;
        private Panel panel4;
        private TextBox textBoxLogin;
        private PictureBox pictureBoxLogin;
        private Panel panel5;
        private TextBox textBoxAccountPrefferences;
        private Panel panel3;
        private TextBox textBox1;
        private PictureBox pictureBox1;

        public TextBox textBoxStatus;
    }
}