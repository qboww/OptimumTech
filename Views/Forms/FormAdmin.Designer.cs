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
            panel6 = new Panel();
            textBoxState = new TextBox();
            buttonDelSave = new Button();
            buttonDelete = new Button();
            textBox3 = new TextBox();
            buttonSearchUser = new Button();
            textBox1 = new TextBox();
            textBoxSearchUserText = new TextBox();
            panel5 = new Panel();
            textBoxStatus = new TextBox();
            textBoxAccountPrefferences = new TextBox();
            panel4 = new Panel();
            listBoxProducts = new ListBox();
            textBoxProducts = new TextBox();
            panel3 = new Panel();
            buttonRepository = new Button();
            textBoxSearchText = new TextBox();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
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
            panelProduct.Location = new Point(0, 190);
            panelProduct.Margin = new Padding(5, 1, 5, 5);
            panelProduct.Name = "panelProduct";
            panelProduct.Padding = new Padding(4, 0, 5, 5);
            panelProduct.Size = new Size(1077, 441);
            panelProduct.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
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
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(30, 30, 30);
            panel6.Controls.Add(textBoxState);
            panel6.Controls.Add(buttonDelSave);
            panel6.Controls.Add(buttonDelete);
            panel6.Controls.Add(textBox3);
            panel6.Controls.Add(buttonSearchUser);
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(textBoxSearchUserText);
            panel6.Location = new Point(728, 44);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(335, 140);
            panel6.TabIndex = 12;
            // 
            // textBoxState
            // 
            textBoxState.BackColor = Color.FromArgb(30, 30, 30);
            textBoxState.BorderStyle = BorderStyle.None;
            textBoxState.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxState.ForeColor = Color.White;
            textBoxState.Location = new Point(55, 72);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(109, 22);
            textBoxState.TabIndex = 8;
            textBoxState.Text = "isn't selected";
            // 
            // buttonDelSave
            // 
            buttonDelSave.BackColor = SystemColors.Window;
            buttonDelSave.FlatAppearance.BorderSize = 0;
            buttonDelSave.FlatStyle = FlatStyle.Flat;
            buttonDelSave.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelSave.Location = new Point(252, 102);
            buttonDelSave.Name = "buttonDelSave";
            buttonDelSave.Size = new Size(75, 29);
            buttonDelSave.TabIndex = 6;
            buttonDelSave.Text = "Save";
            buttonDelSave.UseVisualStyleBackColor = false;
            buttonDelSave.Click += buttonDelSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Window;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(89, 102);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 29);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(30, 30, 30);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(8, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(41, 22);
            textBox3.TabIndex = 5;
            textBox3.Text = "State:";
            // 
            // buttonSearchUser
            // 
            buttonSearchUser.BackColor = SystemColors.Window;
            buttonSearchUser.FlatAppearance.BorderSize = 0;
            buttonSearchUser.FlatStyle = FlatStyle.Flat;
            buttonSearchUser.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchUser.Location = new Point(8, 102);
            buttonSearchUser.Name = "buttonSearchUser";
            buttonSearchUser.Size = new Size(75, 29);
            buttonSearchUser.TabIndex = 5;
            buttonSearchUser.Text = "Search";
            buttonSearchUser.UseVisualStyleBackColor = false;
            buttonSearchUser.Click += buttonSearchUser_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(8, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(319, 26);
            textBox1.TabIndex = 3;
            textBox1.Text = "Delete user by name:";
            // 
            // textBoxSearchUserText
            // 
            textBoxSearchUserText.BorderStyle = BorderStyle.None;
            textBoxSearchUserText.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchUserText.Location = new Point(8, 44);
            textBoxSearchUserText.Name = "textBoxSearchUserText";
            textBoxSearchUserText.Size = new Size(319, 22);
            textBoxSearchUserText.TabIndex = 4;
            textBoxSearchUserText.Text = "Search";
            textBoxSearchUserText.Click += textBoxSearchUserText_Click;
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
            textBoxStatus.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            textBoxAccountPrefferences.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountPrefferences.ForeColor = Color.White;
            textBoxAccountPrefferences.Location = new Point(20, 5);
            textBoxAccountPrefferences.Name = "textBoxAccountPrefferences";
            textBoxAccountPrefferences.ReadOnly = true;
            textBoxAccountPrefferences.Size = new Size(245, 26);
            textBoxAccountPrefferences.TabIndex = 4;
            textBoxAccountPrefferences.Text = "Admin";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 30, 30);
            panel4.Controls.Add(listBoxProducts);
            panel4.Controls.Add(textBoxProducts);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(347, 44);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(325, 140);
            panel4.TabIndex = 12;
            // 
            // listBoxProducts
            // 
            listBoxProducts.BorderStyle = BorderStyle.None;
            listBoxProducts.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 17;
            listBoxProducts.Location = new Point(8, 42);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(309, 85);
            listBoxProducts.TabIndex = 9;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // textBoxProducts
            // 
            textBoxProducts.BackColor = Color.FromArgb(30, 30, 30);
            textBoxProducts.BorderStyle = BorderStyle.None;
            textBoxProducts.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProducts.ForeColor = Color.White;
            textBoxProducts.Location = new Point(8, 8);
            textBoxProducts.Name = "textBoxProducts";
            textBoxProducts.ReadOnly = true;
            textBoxProducts.Size = new Size(319, 26);
            textBoxProducts.TabIndex = 10;
            textBoxProducts.Text = "Select product to edit:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(buttonRepository);
            panel3.Controls.Add(textBoxSearchText);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(buttonSearch);
            panel3.Controls.Add(buttonSave);
            panel3.Location = new Point(12, 44);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(325, 140);
            panel3.TabIndex = 11;
            // 
            // buttonRepository
            // 
            buttonRepository.BackColor = SystemColors.Window;
            buttonRepository.FlatAppearance.BorderSize = 0;
            buttonRepository.FlatStyle = FlatStyle.Flat;
            buttonRepository.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRepository.Location = new Point(184, 102);
            buttonRepository.Name = "buttonRepository";
            buttonRepository.Size = new Size(133, 29);
            buttonRepository.TabIndex = 7;
            buttonRepository.Text = "Open repository";
            buttonRepository.UseVisualStyleBackColor = false;
            buttonRepository.Click += buttonRepository_Click;
            // 
            // textBoxSearchText
            // 
            textBoxSearchText.BackColor = Color.FromArgb(30, 30, 30);
            textBoxSearchText.BorderStyle = BorderStyle.None;
            textBoxSearchText.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchText.ForeColor = Color.White;
            textBoxSearchText.Location = new Point(8, 8);
            textBoxSearchText.Name = "textBoxSearchText";
            textBoxSearchText.ReadOnly = true;
            textBoxSearchText.Size = new Size(319, 26);
            textBoxSearchText.TabIndex = 3;
            textBoxSearchText.Text = "Edit product by name:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(8, 42);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(309, 22);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.Text = "Search";
            textBoxSearch.Click += textBoxSearch_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.Window;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(8, 102);
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
            buttonSave.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(89, 102);
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private ListBox listBoxProducts;
        private TextBox textBoxProducts;
        private Panel panel4;
        private Panel panel5;
        public TextBox textBoxStatus;
        private TextBox textBoxAccountPrefferences;
        private Panel panel6;
        private TextBox textBoxState;
        private Button buttonDelSave;
        private Button buttonDelete;
        private TextBox textBox3;
        private Button buttonSearchUser;
        private TextBox textBox1;
        private TextBox textBoxSearchUserText;
        private Panel panel3;
        private TextBox textBoxSearchText;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonSave;
        private Button buttonRepository;
    }
}