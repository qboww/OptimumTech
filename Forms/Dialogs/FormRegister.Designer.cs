using Optimum_Tech.Resources;

namespace Optimum_Tech.Forms.Dialogs
{
    partial class FormRegister
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
            textBoxDescription = new TextBox();
            pictureBoxClose = new PictureBox();
            panelTitle = new Panel();
            textBoxLogin = new TextBox();
            button1 = new Button();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelTitle.SuspendLayout();
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
            textBoxDescription.Text = "Register";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Image = FormsMedia.close;
            pictureBoxClose.Location = new Point(428, 1);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(25, 27);
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
            panelTitle.Size = new Size(453, 28);
            panelTitle.TabIndex = 16;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(12, 65);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(189, 24);
            textBoxLogin.TabIndex = 18;
            textBoxLogin.TabStop = false;
            textBoxLogin.Text = "Login";
            textBoxLogin.Enter += textBoxLogin_Enter;
            textBoxLogin.Leave += textBoxLogin_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(361, 161);
            button1.Name = "button1";
            button1.Size = new Size(80, 29);
            button1.TabIndex = 21;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 103);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(189, 24);
            textBoxPassword.TabIndex = 22;
            textBoxPassword.TabStop = false;
            textBoxPassword.Text = "Password";
            textBoxPassword.Click += textBoxPassword_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(453, 202);
            Controls.Add(textBoxPassword);
            Controls.Add(button1);
            Controls.Add(textBoxLogin);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDescription;
        private PictureBox pictureBoxClose;
        private Panel panelTitle;
        private TextBox textBoxLogin;
        private Button button1;
        private TextBox textBoxPassword;
    }
}