namespace Optimum_Tech.Views.Controls
{
    partial class SetPostOffice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxAddresses = new ListBox();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBoxCities = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxAddresses
            // 
            listBoxAddresses.BackColor = Color.White;
            listBoxAddresses.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxAddresses.FormattingEnabled = true;
            listBoxAddresses.ItemHeight = 15;
            listBoxAddresses.Location = new Point(13, 77);
            listBoxAddresses.Margin = new Padding(3, 3, 23, 3);
            listBoxAddresses.Name = "listBoxAddresses";
            listBoxAddresses.Size = new Size(452, 154);
            listBoxAddresses.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBoxCities);
            panel1.Controls.Add(listBoxAddresses);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 240);
            panel1.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(40, 40, 40);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(13, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 28);
            textBox3.TabIndex = 43;
            textBox3.Text = "Set post address:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(40, 40, 40);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(13, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(41, 24);
            textBox2.TabIndex = 42;
            textBox2.Text = "City:";
            // 
            // comboBoxCities
            // 
            comboBoxCities.BackColor = Color.White;
            comboBoxCities.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCities.FormattingEnabled = true;
            comboBoxCities.Location = new Point(60, 50);
            comboBoxCities.Name = "comboBoxCities";
            comboBoxCities.Size = new Size(405, 23);
            comboBoxCities.TabIndex = 40;
            comboBoxCities.SelectedIndexChanged += comboBoxCities_SelectedIndexChanged;
            // 
            // SetPostOffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(panel1);
            Name = "SetPostOffice";
            Size = new Size(473, 240);
            Load += SetPostOffice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxAddresses;
        private Panel panel1;
        private ComboBox comboBoxCities;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
