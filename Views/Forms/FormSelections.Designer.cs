namespace Optimum_Tech.View.Forms
{
    partial class FormSelections
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            buttonPurchase = new Button();
            textBoxAmount = new TextBox();
            textBoxPrice = new TextBox();
            panel5 = new Panel();
            textBoxAccountPrefferences = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 40, 5, 5);
            flowLayoutPanel1.Size = new Size(1064, 735);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 611);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 124);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(buttonPurchase);
            panel2.Controls.Add(textBoxAmount);
            panel2.Controls.Add(textBoxPrice);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 96);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(12, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 18);
            textBox1.TabIndex = 4;
            textBox1.Text = "Hint: you are able to increment prduct amount in order pane*";
            // 
            // buttonPurchase
            // 
            buttonPurchase.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPurchase.BackColor = Color.FromArgb(2, 158, 71);
            buttonPurchase.FlatAppearance.BorderSize = 0;
            buttonPurchase.FlatStyle = FlatStyle.Flat;
            buttonPurchase.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPurchase.ForeColor = Color.White;
            buttonPurchase.Location = new Point(928, 30);
            buttonPurchase.Name = "buttonPurchase";
            buttonPurchase.Size = new Size(124, 36);
            buttonPurchase.TabIndex = 3;
            buttonPurchase.Text = "Purchase";
            buttonPurchase.UseVisualStyleBackColor = false;
            buttonPurchase.Click += buttonPurchase_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = Color.FromArgb(30, 30, 30);
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmount.ForeColor = Color.White;
            textBoxAmount.Location = new Point(12, 37);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(206, 28);
            textBoxAmount.TabIndex = 1;
            textBoxAmount.Text = "Amount: ";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(30, 30, 30);
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.ForeColor = Color.White;
            textBoxPrice.Location = new Point(12, 3);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(206, 28);
            textBoxPrice.TabIndex = 0;
            textBoxPrice.Text = "Price: ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxAccountPrefferences);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1064, 34);
            panel5.TabIndex = 11;
            // 
            // textBoxAccountPrefferences
            // 
            textBoxAccountPrefferences.BackColor = Color.FromArgb(30, 30, 30);
            textBoxAccountPrefferences.BorderStyle = BorderStyle.None;
            textBoxAccountPrefferences.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountPrefferences.ForeColor = Color.White;
            textBoxAccountPrefferences.Location = new Point(12, 5);
            textBoxAccountPrefferences.Name = "textBoxAccountPrefferences";
            textBoxAccountPrefferences.Size = new Size(245, 26);
            textBoxAccountPrefferences.TabIndex = 4;
            textBoxAccountPrefferences.Text = "Cart";
            // 
            // FormSelections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 735);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSelections";
            Text = "FormFavorites";
            Load += FormSelections_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox textBoxAmount;
        private TextBox textBoxPrice;
        private Panel panel1;
        private Button buttonPurchase;
        private Panel panel5;
        private TextBox textBoxAccountPrefferences;
        private TextBox textBox1;
    }
}