namespace Optimum_Tech.View.Screens
{
    partial class FormSelectionsEmpty
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
            textBoxUnderLogo = new TextBox();
            pictureBoxLogo = new PictureBox();
            panel5 = new Panel();
            textBoxAccountPrefferences = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUnderLogo
            // 
            textBoxUnderLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUnderLogo.BackColor = SystemColors.ButtonFace;
            textBoxUnderLogo.BorderStyle = BorderStyle.None;
            textBoxUnderLogo.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUnderLogo.ForeColor = SystemColors.WindowFrame;
            textBoxUnderLogo.Location = new Point(-1, 352);
            textBoxUnderLogo.Name = "textBoxUnderLogo";
            textBoxUnderLogo.Size = new Size(1078, 32);
            textBoxUnderLogo.TabIndex = 7;
            textBoxUnderLogo.Text = "Your cart is empty...";
            textBoxUnderLogo.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxLogo.Image = Resources.FormsMedia.cart_48;
            pictureBoxLogo.Location = new Point(0, 250);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(1078, 96);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
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
            textBoxAccountPrefferences.Text = "Cart";
            // 
            // FormSelectionsEmpty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1077, 635);
            Controls.Add(panel5);
            Controls.Add(textBoxUnderLogo);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSelectionsEmpty";
            Text = "FormFavoritesEmpty";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUnderLogo;
        private PictureBox pictureBoxLogo;
        private Panel panel5;
        private TextBox textBoxAccountPrefferences;
    }
}