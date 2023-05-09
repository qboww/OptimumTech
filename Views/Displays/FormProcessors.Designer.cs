namespace Optimum_Tech.Forms
{
    partial class FormProcessors
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
            panel5 = new Panel();
            textBoxProcessors = new TextBox();
            textBox1 = new TextBox();
            textBoxCategory = new TextBox();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 40, 5, 5);
            flowLayoutPanel1.Size = new Size(1064, 735);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxProcessors);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(textBoxCategory);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1064, 34);
            panel5.TabIndex = 13;
            // 
            // textBoxProcessors
            // 
            textBoxProcessors.BackColor = Color.FromArgb(30, 30, 30);
            textBoxProcessors.BorderStyle = BorderStyle.None;
            textBoxProcessors.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProcessors.ForeColor = Color.White;
            textBoxProcessors.Location = new Point(139, 3);
            textBoxProcessors.Name = "textBoxProcessors";
            textBoxProcessors.ReadOnly = true;
            textBoxProcessors.Size = new Size(106, 28);
            textBoxProcessors.TabIndex = 6;
            textBoxProcessors.Text = "Processors";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(112, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(21, 28);
            textBox1.TabIndex = 5;
            textBox1.Text = ">>";
            // 
            // textBoxCategory
            // 
            textBoxCategory.BackColor = Color.FromArgb(30, 30, 30);
            textBoxCategory.BorderStyle = BorderStyle.None;
            textBoxCategory.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategory.ForeColor = Color.White;
            textBoxCategory.Location = new Point(12, 3);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.ReadOnly = true;
            textBoxCategory.Size = new Size(94, 28);
            textBoxCategory.TabIndex = 4;
            textBoxCategory.Text = "Category";
            // 
            // FormProcessors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1064, 735);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProcessors";
            Text = "FormProcessors";
            Load += FormProcessors_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private TextBox textBoxCategory;
        private TextBox textBoxProcessors;
        private TextBox textBox1;
    }
}