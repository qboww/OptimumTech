using Optimum_Tech.Views.Resources;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            textBoxDescription = new TextBox();
            pictureBoxClose = new PictureBox();
            panelTitle = new Panel();
            textBoxLogin = new TextBox();
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            panelTitle.Size = new Size(453, 28);
            panelTitle.TabIndex = 16;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(105, 52);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(189, 24);
            textBoxLogin.TabIndex = 18;
            textBoxLogin.TabStop = false;
            textBoxLogin.Text = "Login";
            textBoxLogin.Enter += textBoxLogin_Enter;
            textBoxLogin.Leave += textBoxLogin_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.White;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.Location = new Point(361, 161);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(80, 29);
            buttonRegister.TabIndex = 21;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(105, 104);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(189, 24);
            textBoxPassword.TabIndex = 22;
            textBoxPassword.TabStop = false;
            textBoxPassword.Text = "Password";
            textBoxPassword.Click += textBoxPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 52);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 23;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 100);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 24;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(40, 40, 40);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(12, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 20);
            textBox1.TabIndex = 25;
            textBox1.Text = "Login should contain at least 3 letters";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(40, 40, 40);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(12, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 20);
            textBox2.TabIndex = 26;
            textBox2.Text = "Password length range 5-15 symbols";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(453, 202);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxLogin);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button buttonRegister;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}