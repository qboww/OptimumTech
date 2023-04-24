using Optimum_Tech.View.Resources;

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
            textBoxManufacturer = new TextBox();
            textBoxSocket = new TextBox();
            textBoxCores = new TextBox();
            textBoxThreads = new TextBox();
            textBoxDefaultSpeed = new TextBox();
            textBoxBoostSpeed = new TextBox();
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
            textBoxDescription.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.ForeColor = Color.White;
            textBoxDescription.Location = new Point(12, 1);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(372, 26);
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
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(772, 28);
            panelTitle.TabIndex = 2;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.ButtonFace;
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.ForeColor = Color.Black;
            textBoxId.Location = new Point(12, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(748, 24);
            textBoxId.TabIndex = 3;
            textBoxId.TabStop = false;
            textBoxId.Text = "Id:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(40, 40, 40);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(12, 88);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(370, 24);
            textBoxName.TabIndex = 4;
            textBoxName.TabStop = false;
            textBoxName.Text = "Name:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(40, 40, 40);
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.ForeColor = Color.White;
            textBoxPrice.Location = new Point(12, 118);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(370, 24);
            textBoxPrice.TabIndex = 5;
            textBoxPrice.TabStop = false;
            textBoxPrice.Text = "Price:";
            // 
            // textBoxResponses
            // 
            textBoxResponses.BackColor = Color.FromArgb(40, 40, 40);
            textBoxResponses.BorderStyle = BorderStyle.None;
            textBoxResponses.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResponses.ForeColor = Color.White;
            textBoxResponses.Location = new Point(12, 148);
            textBoxResponses.Name = "textBoxResponses";
            textBoxResponses.ReadOnly = true;
            textBoxResponses.Size = new Size(370, 24);
            textBoxResponses.TabIndex = 6;
            textBoxResponses.TabStop = false;
            textBoxResponses.Text = "Responses: ";
            // 
            // textBoxRating
            // 
            textBoxRating.BackColor = Color.FromArgb(40, 40, 40);
            textBoxRating.BorderStyle = BorderStyle.None;
            textBoxRating.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRating.ForeColor = Color.White;
            textBoxRating.Location = new Point(12, 178);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.ReadOnly = true;
            textBoxRating.Size = new Size(370, 24);
            textBoxRating.TabIndex = 7;
            textBoxRating.TabStop = false;
            textBoxRating.Text = "Rating: ";
            // 
            // textBoxManufacturer
            // 
            textBoxManufacturer.BackColor = Color.FromArgb(40, 40, 40);
            textBoxManufacturer.BorderStyle = BorderStyle.None;
            textBoxManufacturer.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManufacturer.ForeColor = Color.White;
            textBoxManufacturer.Location = new Point(388, 88);
            textBoxManufacturer.Name = "textBoxManufacturer";
            textBoxManufacturer.ReadOnly = true;
            textBoxManufacturer.Size = new Size(372, 24);
            textBoxManufacturer.TabIndex = 8;
            textBoxManufacturer.TabStop = false;
            textBoxManufacturer.Text = "Manufacturer: ";
            // 
            // textBoxSocket
            // 
            textBoxSocket.BackColor = Color.FromArgb(40, 40, 40);
            textBoxSocket.BorderStyle = BorderStyle.None;
            textBoxSocket.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSocket.ForeColor = Color.White;
            textBoxSocket.Location = new Point(388, 118);
            textBoxSocket.Name = "textBoxSocket";
            textBoxSocket.ReadOnly = true;
            textBoxSocket.Size = new Size(372, 24);
            textBoxSocket.TabIndex = 10;
            textBoxSocket.TabStop = false;
            textBoxSocket.Text = "Socket:";
            // 
            // textBoxCores
            // 
            textBoxCores.BackColor = Color.FromArgb(40, 40, 40);
            textBoxCores.BorderStyle = BorderStyle.None;
            textBoxCores.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCores.ForeColor = Color.White;
            textBoxCores.Location = new Point(388, 148);
            textBoxCores.Name = "textBoxCores";
            textBoxCores.ReadOnly = true;
            textBoxCores.Size = new Size(372, 24);
            textBoxCores.TabIndex = 11;
            textBoxCores.TabStop = false;
            textBoxCores.Text = "Cores: ";
            // 
            // textBoxThreads
            // 
            textBoxThreads.BackColor = Color.FromArgb(40, 40, 40);
            textBoxThreads.BorderStyle = BorderStyle.None;
            textBoxThreads.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxThreads.ForeColor = Color.White;
            textBoxThreads.Location = new Point(388, 178);
            textBoxThreads.Name = "textBoxThreads";
            textBoxThreads.ReadOnly = true;
            textBoxThreads.Size = new Size(372, 24);
            textBoxThreads.TabIndex = 12;
            textBoxThreads.TabStop = false;
            textBoxThreads.Text = "Threads:";
            // 
            // textBoxDefaultSpeed
            // 
            textBoxDefaultSpeed.BackColor = Color.FromArgb(40, 40, 40);
            textBoxDefaultSpeed.BorderStyle = BorderStyle.None;
            textBoxDefaultSpeed.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDefaultSpeed.ForeColor = Color.White;
            textBoxDefaultSpeed.Location = new Point(388, 208);
            textBoxDefaultSpeed.Name = "textBoxDefaultSpeed";
            textBoxDefaultSpeed.ReadOnly = true;
            textBoxDefaultSpeed.Size = new Size(372, 24);
            textBoxDefaultSpeed.TabIndex = 13;
            textBoxDefaultSpeed.TabStop = false;
            textBoxDefaultSpeed.Text = "Default Speed: ";
            // 
            // textBoxBoostSpeed
            // 
            textBoxBoostSpeed.BackColor = Color.FromArgb(40, 40, 40);
            textBoxBoostSpeed.BorderStyle = BorderStyle.None;
            textBoxBoostSpeed.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBoostSpeed.ForeColor = Color.White;
            textBoxBoostSpeed.Location = new Point(388, 238);
            textBoxBoostSpeed.Name = "textBoxBoostSpeed";
            textBoxBoostSpeed.ReadOnly = true;
            textBoxBoostSpeed.Size = new Size(372, 24);
            textBoxBoostSpeed.TabIndex = 14;
            textBoxBoostSpeed.TabStop = false;
            textBoxBoostSpeed.Text = "Boost Speed: ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(textBoxId);
            panel1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            Controls.Add(textBoxBoostSpeed);
            Controls.Add(textBoxDefaultSpeed);
            Controls.Add(textBoxThreads);
            Controls.Add(textBoxCores);
            Controls.Add(textBoxSocket);
            Controls.Add(textBoxManufacturer);
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
        private TextBox textBoxManufacturer;
        private TextBox textBoxSocket;
        private TextBox textBoxCores;
        private TextBox textBoxThreads;
        private TextBox textBoxDefaultSpeed;
        private TextBox textBoxBoostSpeed;
        private Panel panel1;
    }
}