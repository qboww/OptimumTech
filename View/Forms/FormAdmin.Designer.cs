using Optimum_Tech.View.Resources;

namespace Optimum_Tech.View.Forms
{
    partial class FormAdmin
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
            panelProduct = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            textBoxStatus = new TextBox();
            textBoxAccountPrefferences = new TextBox();
            panel4 = new Panel();
            listBoxProducts = new ListBox();
            textBoxProducts = new TextBox();
            panel3 = new Panel();
            textBoxSearchText = new TextBox();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panelProduct);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 635);
            panel1.TabIndex = 4;
            // 
            // panelProduct
            // 
            panelProduct.Location = new Point(0, 183);
            panelProduct.Margin = new Padding(5);
            panelProduct.Name = "panelProduct";
            panelProduct.Padding = new Padding(4, 0, 5, 5);
            panelProduct.Size = new Size(1077, 452);
            panelProduct.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 635);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxStatus);
            panel5.Controls.Add(textBoxAccountPrefferences);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1077, 34);
            panel5.TabIndex = 13;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxStatus.BackColor = Color.FromArgb(30, 30, 30);
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStatus.ForeColor = Color.White;
            textBoxStatus.Location = new Point(1386, 3);
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
            textBoxAccountPrefferences.Text = "Admin";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 30, 30);
            panel4.Controls.Add(listBoxProducts);
            panel4.Controls.Add(textBoxProducts);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(430, 44);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(347, 141);
            panel4.TabIndex = 12;
            // 
            // listBoxProducts
            // 
            listBoxProducts.BorderStyle = BorderStyle.None;
            listBoxProducts.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 23;
            listBoxProducts.Location = new Point(8, 39);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(331, 92);
            listBoxProducts.TabIndex = 9;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // textBoxProducts
            // 
            textBoxProducts.BackColor = Color.FromArgb(30, 30, 30);
            textBoxProducts.BorderStyle = BorderStyle.None;
            textBoxProducts.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProducts.ForeColor = Color.White;
            textBoxProducts.Location = new Point(8, 0);
            textBoxProducts.Name = "textBoxProducts";
            textBoxProducts.ReadOnly = true;
            textBoxProducts.Size = new Size(331, 28);
            textBoxProducts.TabIndex = 10;
            textBoxProducts.Text = "Select product to edit:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(textBoxSearchText);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(buttonSearch);
            panel3.Controls.Add(buttonSave);
            panel3.Location = new Point(12, 44);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(408, 141);
            panel3.TabIndex = 11;
            // 
            // textBoxSearchText
            // 
            textBoxSearchText.BackColor = Color.FromArgb(30, 30, 30);
            textBoxSearchText.BorderStyle = BorderStyle.None;
            textBoxSearchText.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchText.ForeColor = Color.White;
            textBoxSearchText.Location = new Point(8, -2);
            textBoxSearchText.Name = "textBoxSearchText";
            textBoxSearchText.ReadOnly = true;
            textBoxSearchText.Size = new Size(331, 28);
            textBoxSearchText.TabIndex = 3;
            textBoxSearchText.Text = "Search by name:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(8, 32);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(392, 20);
            textBoxSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.Window;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(8, 67);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 29);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.Window;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(8, 102);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1077, 635);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            Text = "FormHome";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelProduct;
        private Panel panel2;
        private TextBox textBoxSearch;
        private TextBox textBoxSearchText;
        private Button buttonSearch;
        private Button buttonSave;
        private ListBox listBoxProducts;
        private TextBox textBoxProducts;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        public TextBox textBoxStatus;
        private TextBox textBoxAccountPrefferences;
    }
}