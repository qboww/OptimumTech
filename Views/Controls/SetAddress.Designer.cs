namespace Optimum_Tech.Views.Controls
{
    partial class SetAddress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAddress = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.White;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(93, 38);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(284, 24);
            textBoxAddress.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(40, 40, 40);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(12, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 24);
            textBox2.TabIndex = 43;
            textBox2.Text = "Address:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(40, 40, 40);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 29);
            textBox1.TabIndex = 44;
            textBox1.Text = "Set address";
            // 
            // SetAddress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBoxAddress);
            Name = "SetAddress";
            Size = new Size(432, 85);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
