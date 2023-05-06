namespace Optimum_Tech.View.Forms
{
    partial class FormSettings
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
            panel5 = new Panel();
            textBoxStatus = new TextBox();
            textBoxAccountPrefferences = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            buttonBanner = new Button();
            textBox2 = new TextBox();
            textBoxState = new TextBox();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxStatus);
            panel5.Controls.Add(textBoxAccountPrefferences);
            panel5.Dock = DockStyle.Top;
            panel5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1064, 34);
            panel5.TabIndex = 14;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxStatus.BackColor = Color.FromArgb(30, 30, 30);
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStatus.ForeColor = Color.White;
            textBoxStatus.Location = new Point(2250, 3);
            textBoxStatus.Name = "textBoxStatus";
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
            textBoxAccountPrefferences.Location = new Point(20, 3);
            textBoxAccountPrefferences.Name = "textBoxAccountPrefferences";
            textBoxAccountPrefferences.ReadOnly = true;
            textBoxAccountPrefferences.Size = new Size(245, 28);
            textBoxAccountPrefferences.TabIndex = 4;
            textBoxAccountPrefferences.Text = "Settings";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 701);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 25, 25);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(buttonBanner);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBoxState);
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 70);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(25, 25, 25);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(9, 9);
            textBox1.Margin = new Padding(9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "Disable home page banner:";
            // 
            // buttonBanner
            // 
            buttonBanner.BackColor = Color.White;
            buttonBanner.FlatAppearance.BorderSize = 0;
            buttonBanner.FlatStyle = FlatStyle.Flat;
            buttonBanner.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBanner.Location = new Point(392, 12);
            buttonBanner.Margin = new Padding(9);
            buttonBanner.Name = "buttonBanner";
            buttonBanner.Size = new Size(84, 29);
            buttonBanner.TabIndex = 1;
            buttonBanner.Text = "Change";
            buttonBanner.UseVisualStyleBackColor = false;
            buttonBanner.Click += buttonBanner_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(25, 25, 25);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(9, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 24);
            textBox2.TabIndex = 2;
            textBox2.Text = "Banner:";
            // 
            // textBoxState
            // 
            textBoxState.BackColor = Color.FromArgb(25, 25, 25);
            textBoxState.BorderStyle = BorderStyle.None;
            textBoxState.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxState.ForeColor = Color.LimeGreen;
            textBoxState.Location = new Point(79, 36);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(78, 24);
            textBoxState.TabIndex = 3;
            textBoxState.Text = "Enabled";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1064, 735);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSettings";
            Text = "FormContact";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        public TextBox textBoxStatus;
        private TextBox textBoxAccountPrefferences;
        private Panel panel1;
        private TextBox textBoxState;
        private TextBox textBox2;
        private Button buttonBanner;
        private TextBox textBox1;
        private Panel panel2;
    }
}