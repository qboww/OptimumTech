using Optimum_Tech.Views.Resources;

namespace Optimum_Tech.Forms.Dialogs
{
    partial class FormDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescription));
            textBoxDescription = new TextBox();
            pictureBoxClose = new PictureBox();
            panelTitle = new Panel();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxResponses = new TextBox();
            textBoxRating = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelTitle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDescription
            // 
            textBoxDescription.BackColor = Color.FromArgb(20, 20, 20);
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Font = new Font("Segoe UI Variable Display", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.ForeColor = Color.White;
            textBoxDescription.Location = new Point(12, 1);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(372, 23);
            textBoxDescription.TabIndex = 0;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "Product Description";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Image = FormsMedia.close;
            pictureBoxClose.Location = new Point(747, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(23, 25);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(20, 20, 20);
            panelTitle.Controls.Add(textBoxDescription);
            panelTitle.Controls.Add(pictureBoxClose);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(772, 28);
            panelTitle.TabIndex = 2;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.ButtonFace;
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.ForeColor = Color.Black;
            textBoxId.Location = new Point(12, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(748, 22);
            textBoxId.TabIndex = 3;
            textBoxId.TabStop = false;
            textBoxId.Text = "Id:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(40, 40, 40);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(12, 88);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(370, 22);
            textBoxName.TabIndex = 4;
            textBoxName.TabStop = false;
            textBoxName.Text = "Name:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(40, 40, 40);
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.ForeColor = Color.White;
            textBoxPrice.Location = new Point(12, 118);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(370, 22);
            textBoxPrice.TabIndex = 5;
            textBoxPrice.TabStop = false;
            textBoxPrice.Text = "Price:";
            // 
            // textBoxResponses
            // 
            textBoxResponses.BackColor = Color.FromArgb(40, 40, 40);
            textBoxResponses.BorderStyle = BorderStyle.None;
            textBoxResponses.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResponses.ForeColor = Color.White;
            textBoxResponses.Location = new Point(12, 148);
            textBoxResponses.Name = "textBoxResponses";
            textBoxResponses.ReadOnly = true;
            textBoxResponses.Size = new Size(370, 22);
            textBoxResponses.TabIndex = 6;
            textBoxResponses.TabStop = false;
            textBoxResponses.Text = "Responses: ";
            // 
            // textBoxRating
            // 
            textBoxRating.BackColor = Color.FromArgb(40, 40, 40);
            textBoxRating.BorderStyle = BorderStyle.None;
            textBoxRating.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRating.ForeColor = Color.White;
            textBoxRating.Location = new Point(12, 178);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.ReadOnly = true;
            textBoxRating.Size = new Size(370, 22);
            textBoxRating.TabIndex = 7;
            textBoxRating.TabStop = false;
            textBoxRating.Text = "Rating: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(40, 40, 40);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(388, 88);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(372, 22);
            textBox1.TabIndex = 8;
            textBox1.TabStop = false;
            textBox1.Text = "Property 1:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(40, 40, 40);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(388, 118);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(372, 22);
            textBox2.TabIndex = 10;
            textBox2.TabStop = false;
            textBox2.Text = "Property 2:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(40, 40, 40);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(388, 148);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(372, 22);
            textBox3.TabIndex = 11;
            textBox3.TabStop = false;
            textBox3.Text = "Property 3:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(40, 40, 40);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(388, 178);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(372, 22);
            textBox4.TabIndex = 12;
            textBox4.TabStop = false;
            textBox4.Text = "Property 4:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(40, 40, 40);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(388, 208);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(372, 22);
            textBox5.TabIndex = 13;
            textBox5.TabStop = false;
            textBox5.Text = "Property 5:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(40, 40, 40);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(388, 238);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(372, 22);
            textBox6.TabIndex = 14;
            textBox6.TabStop = false;
            textBox6.Text = "Property 6:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(textBoxId);
            panel1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 28);
            panel1.TabIndex = 15;
            // 
            // FormDescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(772, 450);
            Controls.Add(panel1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxRating);
            Controls.Add(textBoxResponses);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Descripton";
            Load += FormDescription_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDescription;
        private PictureBox pictureBoxClose;
        private Panel panelTitle;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxResponses;
        private TextBox textBoxRating;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel panel1;
    }
}