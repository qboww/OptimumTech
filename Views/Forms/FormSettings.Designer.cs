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
            panel3 = new Panel();
            textBox3 = new TextBox();
            buttonUpdate = new Button();
            textBox4 = new TextBox();
            textBoxStatusAPI = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            buttonBanner = new Button();
            textBox2 = new TextBox();
            textBoxState = new TextBox();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            textBoxStatus.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStatus.ForeColor = Color.White;
            textBoxStatus.Location = new Point(2250, 3);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(279, 25);
            textBoxStatus.TabIndex = 6;
            textBoxStatus.Text = "Status: Unlogged";
            textBoxStatus.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxAccountPrefferences
            // 
            textBoxAccountPrefferences.BackColor = Color.FromArgb(30, 30, 30);
            textBoxAccountPrefferences.BorderStyle = BorderStyle.None;
            textBoxAccountPrefferences.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountPrefferences.ForeColor = Color.White;
            textBoxAccountPrefferences.Location = new Point(20, 3);
            textBoxAccountPrefferences.Name = "textBoxAccountPrefferences";
            textBoxAccountPrefferences.ReadOnly = true;
            textBoxAccountPrefferences.Size = new Size(245, 26);
            textBoxAccountPrefferences.TabIndex = 4;
            textBoxAccountPrefferences.Text = "Settings";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 701);
            panel1.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 25, 25);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(buttonUpdate);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBoxStatusAPI);
            panel3.Location = new Point(0, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 70);
            panel3.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(25, 25, 25);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(9, 9);
            textBox3.Margin = new Padding(9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 22);
            textBox3.TabIndex = 0;
            textBox3.Text = "Update NovaPost API:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.White;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(392, 12);
            buttonUpdate.Margin = new Padding(9);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(84, 29);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(25, 25, 25);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(9, 36);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(41, 22);
            textBox4.TabIndex = 2;
            textBox4.Text = "State:";
            // 
            // textBoxStatusAPI
            // 
            textBoxStatusAPI.BackColor = Color.FromArgb(25, 25, 25);
            textBoxStatusAPI.BorderStyle = BorderStyle.None;
            textBoxStatusAPI.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStatusAPI.ForeColor = Color.Red;
            textBoxStatusAPI.Location = new Point(56, 36);
            textBoxStatusAPI.Name = "textBoxStatusAPI";
            textBoxStatusAPI.Size = new Size(156, 22);
            textBoxStatusAPI.TabIndex = 3;
            textBoxStatusAPI.Text = "Not checked";
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
            textBox1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(9, 9);
            textBox1.Margin = new Padding(9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 22);
            textBox1.TabIndex = 0;
            textBox1.Text = "Disable home page banner:";
            // 
            // buttonBanner
            // 
            buttonBanner.BackColor = Color.White;
            buttonBanner.FlatAppearance.BorderSize = 0;
            buttonBanner.FlatStyle = FlatStyle.Flat;
            buttonBanner.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBanner.Location = new Point(392, 12);
            buttonBanner.Margin = new Padding(9);
            buttonBanner.Name = "buttonBanner";
            buttonBanner.Size = new Size(84, 29);
            buttonBanner.TabIndex = 1;
            buttonBanner.Text = "Interact";
            buttonBanner.UseVisualStyleBackColor = false;
            buttonBanner.Click += buttonBanner_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(25, 25, 25);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(9, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(41, 22);
            textBox2.TabIndex = 2;
            textBox2.Text = "State:";
            // 
            // textBoxState
            // 
            textBoxState.BackColor = Color.FromArgb(25, 25, 25);
            textBoxState.BorderStyle = BorderStyle.None;
            textBoxState.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxState.ForeColor = Color.LimeGreen;
            textBoxState.Location = new Point(56, 36);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(78, 22);
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel3;
        private TextBox textBox3;
        private Button buttonUpdate;
        private TextBox textBox4;
        private TextBox textBoxStatusAPI;
    }
}