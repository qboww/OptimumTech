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
            panel2 = new Panel();
            listBoxProducts = new ListBox();
            textBoxProducts = new TextBox();
            panel5 = new Panel();
            textBoxAccountPrefferences = new TextBox();
            buttonSave = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            textBoxSearchText = new TextBox();
            panelProduct = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelProduct);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 635);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBoxProducts);
            panel2.Controls.Add(textBoxProducts);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(buttonSave);
            panel2.Controls.Add(buttonSearch);
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(textBoxSearchText);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 229);
            panel2.TabIndex = 4;
            // 
            // listBoxProducts
            // 
            listBoxProducts.BorderStyle = BorderStyle.None;
            listBoxProducts.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 28;
            listBoxProducts.Location = new Point(390, 105);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(271, 112);
            listBoxProducts.TabIndex = 9;
            // 
            // textBoxProducts
            // 
            textBoxProducts.BorderStyle = BorderStyle.None;
            textBoxProducts.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProducts.Location = new Point(390, 48);
            textBoxProducts.Name = "textBoxProducts";
            textBoxProducts.Size = new Size(271, 28);
            textBoxProducts.TabIndex = 10;
            textBoxProducts.Text = "Select product to edit:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxAccountPrefferences);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1077, 34);
            panel5.TabIndex = 8;
            // 
            // textBoxAccountPrefferences
            // 
            textBoxAccountPrefferences.BackColor = Color.FromArgb(30, 30, 30);
            textBoxAccountPrefferences.BorderStyle = BorderStyle.None;
            textBoxAccountPrefferences.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountPrefferences.ForeColor = Color.White;
            textBoxAccountPrefferences.Location = new Point(12, 3);
            textBoxAccountPrefferences.Name = "textBoxAccountPrefferences";
            textBoxAccountPrefferences.Size = new Size(245, 28);
            textBoxAccountPrefferences.TabIndex = 4;
            textBoxAccountPrefferences.Text = "Admin";
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.BackColor = SystemColors.Window;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(12, 182);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 35);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.AutoSize = true;
            buttonSearch.BackColor = SystemColors.Window;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(12, 114);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 35);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(12, 84);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(322, 24);
            textBoxSearch.TabIndex = 4;
            // 
            // textBoxSearchText
            // 
            textBoxSearchText.BorderStyle = BorderStyle.None;
            textBoxSearchText.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchText.Location = new Point(12, 48);
            textBoxSearchText.Name = "textBoxSearchText";
            textBoxSearchText.Size = new Size(322, 28);
            textBoxSearchText.TabIndex = 3;
            textBoxSearchText.Text = "Search by name:";
            // 
            // panelProduct
            // 
            panelProduct.Dock = DockStyle.Bottom;
            panelProduct.Location = new Point(0, 229);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(1077, 406);
            panelProduct.TabIndex = 5;
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
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel5;
        private TextBox textBoxAccountPrefferences;
    }
}