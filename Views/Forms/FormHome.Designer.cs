using Optimum_Tech.Views.Resources;

namespace Optimum_Tech.Forms
{
    partial class FormHome
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
            panelBanner = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            textBoxAccountPrefferences = new TextBox();
            textBoxUnderLogo = new TextBox();
            pictureBoxLogo = new PictureBox();
            panel1.SuspendLayout();
            panelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panelBanner);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(textBoxUnderLogo);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 635);
            panel1.TabIndex = 4;
            // 
            // panelBanner
            // 
            panelBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBanner.BackColor = Color.FromArgb(91, 119, 66);
            panelBanner.Controls.Add(label1);
            panelBanner.Controls.Add(pictureBox1);
            panelBanner.Location = new Point(0, 40);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(1078, 55);
            panelBanner.TabIndex = 15;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Laqonic 4F Unicase", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(656, 55);
            label1.TabIndex = 16;
            label1.Text = "ТВОРИМО ІСТОРІЮ РАЗОМ! ПІДТРИМАЙТЕ БФ\"ПОВЕРНИСЬ ЖИВИМ\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = FormsMedia.donate_button;
            pictureBox1.Location = new Point(908, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxAccountPrefferences);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1077, 34);
            panel5.TabIndex = 14;
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
            textBoxAccountPrefferences.Text = "Home";
            // 
            // textBoxUnderLogo
            // 
            textBoxUnderLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUnderLogo.BackColor = SystemColors.Control;
            textBoxUnderLogo.BorderStyle = BorderStyle.None;
            textBoxUnderLogo.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUnderLogo.Location = new Point(-1, 377);
            textBoxUnderLogo.Name = "textBoxUnderLogo";
            textBoxUnderLogo.Size = new Size(1078, 32);
            textBoxUnderLogo.TabIndex = 5;
            textBoxUnderLogo.Text = "Build PC with less effort!";
            textBoxUnderLogo.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxLogo.Image = FormsMedia.optimum_tech_100;
            pictureBoxLogo.Location = new Point(0, 275);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(1078, 96);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1077, 635);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHome";
            Text = "FormHome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxUnderLogo;
        private PictureBox pictureBoxLogo;
        private Panel panel5;
        private TextBox textBoxAccountPrefferences;
        private PictureBox pictureBox1;
        private Label label1;

        public Panel panelBanner;
    }
}