namespace Optimum_Tech.Forms
{
    partial class FormFavorites
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
            textBoxUnderLogo = new TextBox();
            pictureBoxLogo = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(textBoxUnderLogo);
            flowLayoutPanel1.Controls.Add(pictureBoxLogo);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1064, 735);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textBoxUnderLogo
            // 
            textBoxUnderLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUnderLogo.BackColor = SystemColors.ButtonFace;
            textBoxUnderLogo.BorderStyle = BorderStyle.None;
            textBoxUnderLogo.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUnderLogo.ForeColor = SystemColors.WindowFrame;
            textBoxUnderLogo.Location = new Point(-7, 394);
            textBoxUnderLogo.Name = "textBoxUnderLogo";
            textBoxUnderLogo.Size = new Size(1078, 32);
            textBoxUnderLogo.TabIndex = 7;
            textBoxUnderLogo.Text = "Favorites list is empty...";
            textBoxUnderLogo.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxLogo.Image = View.Resources.FormsMedia.favorites_screen_empty;
            pictureBoxLogo.Location = new Point(-6, 292);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(1078, 96);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // FormFavorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 735);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFavorites";
            Text = "FormFavorites";
            Load += FormFavorites_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBoxUnderLogo;
        private PictureBox pictureBoxLogo;
    }
}