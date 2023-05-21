using Optimum_Tech.Views.Resources;

namespace Optimum_Tech.Forms.Dialogs
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelTitle = new Panel();
            pictureBoxClose = new PictureBox();
            textBoxTitleAccount = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            linkLabel1 = new LinkLabel();
            buttonLogin = new Button();
            pictureBox1 = new PictureBox();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(20, 20, 20);
            panelTitle.Controls.Add(pictureBoxClose);
            panelTitle.Controls.Add(textBoxTitleAccount);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(297, 28);
            panelTitle.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Image = FormsMedia.close;
            pictureBoxClose.Location = new Point(272, 2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(23, 25);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // textBoxTitleAccount
            // 
            textBoxTitleAccount.BackColor = Color.FromArgb(20, 20, 20);
            textBoxTitleAccount.BorderStyle = BorderStyle.None;
            textBoxTitleAccount.Font = new Font("Segoe UI Variable Display", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitleAccount.ForeColor = Color.White;
            textBoxTitleAccount.Location = new Point(12, 2);
            textBoxTitleAccount.Name = "textBoxTitleAccount";
            textBoxTitleAccount.ReadOnly = true;
            textBoxTitleAccount.Size = new Size(100, 23);
            textBoxTitleAccount.TabIndex = 1;
            textBoxTitleAccount.TabStop = false;
            textBoxTitleAccount.Text = "Login";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 376);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(247, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 376);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(buttonLogin);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBoxPassword);
            panel3.Controls.Add(textBoxLogin);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(50, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 376);
            panel3.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(2, 266);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Padding = new Padding(3, 0, 0, 0);
            linkLabel1.Size = new Size(60, 17);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.BackColor = Color.White;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(50, 322);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(95, 33);
            buttonLogin.TabIndex = 2;
            buttonLogin.TabStop = false;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = FormsMedia.account_48;
            pictureBox1.Location = new Point(0, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(9, 241);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(182, 22);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.Text = "Password";
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(9, 201);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(182, 22);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(297, 404);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private PictureBox pictureBoxClose;
        private TextBox textBoxTitleAccount;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonLogin;
        private PictureBox pictureBox1;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private LinkLabel linkLabel1;
    }
}