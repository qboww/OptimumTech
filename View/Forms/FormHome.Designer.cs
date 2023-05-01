using Optimum_Tech.View.Resources;

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
            panel5 = new Panel();
            textBoxAccountPrefferences = new TextBox();
            textBoxUnderLogo = new TextBox();
            pictureBoxLogo = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(textBoxUnderLogo);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 635);
            panel1.TabIndex = 4;
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
    }
}