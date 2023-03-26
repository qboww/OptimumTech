using Optimum_Tech.Controls;
using System.Windows.Forms.VisualStyles;

namespace OptimumTech
{
    partial class FormMainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainScreen));
            panelTitleBar = new Panel();
            buttonMinimize = new Button();
            buttonClose = new Button();
            buttonMaximize = new Button();
            panelCollapsed = new Panel();
            buttonDrawer = new Button();
            buttonSearch = new Button();
            buttonAdmin = new Button();
            buttonCategory = new Button();
            buttonSettings = new Button();
            buttonContact = new Button();
            buttonHome = new Button();
            buttonAccount = new Button();
            buttonFavourites = new Button();
            buttonCart = new Button();
            panelSlide = new Panel();
            labelAdmin = new Label();
            labelContact = new Label();
            labelCategory = new Label();
            labelSettings = new Label();
            labelFavourites = new Label();
            labelCart = new Label();
            labelAccount = new Label();
            labelHome = new Label();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            panelMain = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panelTitleBar.SuspendLayout();
            panelCollapsed.SuspendLayout();
            panelSlide.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.Desktop;
            panelTitleBar.Controls.Add(buttonMinimize);
            panelTitleBar.Controls.Add(buttonClose);
            panelTitleBar.Controls.Add(buttonMaximize);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1245, 27);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            panelTitleBar.MouseMove += panelTitleBar_MouseMove;
            panelTitleBar.MouseUp += panelTitleBar_MouseUp;
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Optimum_Tech.Properties.Resources.minimize;
            buttonMinimize.Location = new Point(1158, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(25, 27);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Optimum_Tech.Properties.Resources.close;
            buttonClose.Location = new Point(1220, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(25, 27);
            buttonClose.TabIndex = 0;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonMaximize
            // 
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.ForeColor = Color.White;
            buttonMaximize.Image = Optimum_Tech.Properties.Resources.maximize;
            buttonMaximize.Location = new Point(1189, 0);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(25, 27);
            buttonMaximize.TabIndex = 0;
            buttonMaximize.UseVisualStyleBackColor = true;
            buttonMaximize.Click += buttonMaximize_Click;
            // 
            // panelCollapsed
            // 
            panelCollapsed.BackColor = Color.FromArgb(35, 35, 35);
            panelCollapsed.Controls.Add(buttonDrawer);
            panelCollapsed.Controls.Add(buttonSearch);
            panelCollapsed.Controls.Add(buttonAdmin);
            panelCollapsed.Controls.Add(buttonCategory);
            panelCollapsed.Controls.Add(buttonSettings);
            panelCollapsed.Controls.Add(buttonContact);
            panelCollapsed.Controls.Add(buttonHome);
            panelCollapsed.Controls.Add(buttonAccount);
            panelCollapsed.Controls.Add(buttonFavourites);
            panelCollapsed.Controls.Add(buttonCart);
            panelCollapsed.Dock = DockStyle.Left;
            panelCollapsed.Location = new Point(0, 27);
            panelCollapsed.Name = "panelCollapsed";
            panelCollapsed.Size = new Size(46, 793);
            panelCollapsed.TabIndex = 1;
            // 
            // buttonDrawer
            // 
            buttonDrawer.FlatAppearance.BorderSize = 0;
            buttonDrawer.FlatStyle = FlatStyle.Flat;
            buttonDrawer.Image = Optimum_Tech.Properties.Resources.drawer;
            buttonDrawer.Location = new Point(0, 16);
            buttonDrawer.Name = "buttonDrawer";
            buttonDrawer.Size = new Size(46, 30);
            buttonDrawer.TabIndex = 0;
            buttonDrawer.UseVisualStyleBackColor = true;
            buttonDrawer.Click += buttonDrawer_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = SystemColors.ControlText;
            buttonSearch.Image = Optimum_Tech.Properties.Resources.search;
            buttonSearch.Location = new Point(0, 87);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(46, 30);
            buttonSearch.TabIndex = 0;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Image = Optimum_Tech.Properties.Resources.admin;
            buttonAdmin.Location = new Point(-1, 679);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(47, 30);
            buttonAdmin.TabIndex = 10;
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Visible = false;
            // 
            // buttonCategory
            // 
            buttonCategory.FlatAppearance.BorderSize = 0;
            buttonCategory.FlatStyle = FlatStyle.Flat;
            buttonCategory.Image = Optimum_Tech.Properties.Resources.category;
            buttonCategory.Location = new Point(0, 168);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(47, 30);
            buttonCategory.TabIndex = 0;
            buttonCategory.UseVisualStyleBackColor = true;
            buttonCategory.Click += buttonCategory_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Image = Optimum_Tech.Properties.Resources.settings;
            buttonSettings.Location = new Point(0, 751);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(47, 30);
            buttonSettings.TabIndex = 0;
            buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonContact
            // 
            buttonContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonContact.FlatAppearance.BorderSize = 0;
            buttonContact.FlatStyle = FlatStyle.Flat;
            buttonContact.Image = Optimum_Tech.Properties.Resources.contact;
            buttonContact.Location = new Point(-1, 715);
            buttonContact.Name = "buttonContact";
            buttonContact.Size = new Size(47, 30);
            buttonContact.TabIndex = 0;
            buttonContact.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Image = Optimum_Tech.Properties.Resources.home;
            buttonHome.Location = new Point(0, 204);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(47, 30);
            buttonHome.TabIndex = 0;
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonAccount
            // 
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Image = Optimum_Tech.Properties.Resources.account;
            buttonAccount.Location = new Point(0, 240);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(47, 30);
            buttonAccount.TabIndex = 0;
            buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonFavourites
            // 
            buttonFavourites.FlatAppearance.BorderSize = 0;
            buttonFavourites.FlatStyle = FlatStyle.Flat;
            buttonFavourites.Image = Optimum_Tech.Properties.Resources.favorite;
            buttonFavourites.Location = new Point(0, 312);
            buttonFavourites.Name = "buttonFavourites";
            buttonFavourites.Size = new Size(47, 30);
            buttonFavourites.TabIndex = 0;
            buttonFavourites.UseVisualStyleBackColor = true;
            // 
            // buttonCart
            // 
            buttonCart.FlatAppearance.BorderSize = 0;
            buttonCart.FlatStyle = FlatStyle.Flat;
            buttonCart.Image = Optimum_Tech.Properties.Resources.cart;
            buttonCart.Location = new Point(0, 276);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(47, 30);
            buttonCart.TabIndex = 0;
            buttonCart.UseVisualStyleBackColor = true;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.FromArgb(35, 35, 35);
            panelSlide.Controls.Add(labelAdmin);
            panelSlide.Controls.Add(labelContact);
            panelSlide.Controls.Add(labelCategory);
            panelSlide.Controls.Add(labelSettings);
            panelSlide.Controls.Add(labelFavourites);
            panelSlide.Controls.Add(labelCart);
            panelSlide.Controls.Add(labelAccount);
            panelSlide.Controls.Add(labelHome);
            panelSlide.Controls.Add(labelSearch);
            panelSlide.Controls.Add(textBoxSearch);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(46, 27);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(170, 793);
            panelSlide.TabIndex = 2;
            // 
            // labelAdmin
            // 
            labelAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelAdmin.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdmin.ForeColor = Color.White;
            labelAdmin.Location = new Point(0, 679);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(75, 30);
            labelAdmin.TabIndex = 0;
            labelAdmin.Text = "Admin";
            labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelAdmin.Visible = false;
            // 
            // labelContact
            // 
            labelContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelContact.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelContact.ForeColor = Color.White;
            labelContact.Location = new Point(0, 715);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(93, 30);
            labelContact.TabIndex = 11;
            labelContact.Text = "Contact";
            labelContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCategory
            // 
            labelCategory.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategory.ForeColor = Color.White;
            labelCategory.Location = new Point(0, 168);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(93, 30);
            labelCategory.TabIndex = 9;
            labelCategory.Text = "Category";
            labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSettings
            // 
            labelSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSettings.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings.ForeColor = Color.White;
            labelSettings.Location = new Point(0, 751);
            labelSettings.Name = "labelSettings";
            labelSettings.Size = new Size(85, 30);
            labelSettings.TabIndex = 8;
            labelSettings.Text = "Settings";
            labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFavourites
            // 
            labelFavourites.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelFavourites.ForeColor = Color.White;
            labelFavourites.Location = new Point(0, 312);
            labelFavourites.Name = "labelFavourites";
            labelFavourites.Size = new Size(93, 30);
            labelFavourites.TabIndex = 7;
            labelFavourites.Text = "Favourites";
            labelFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCart
            // 
            labelCart.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCart.ForeColor = Color.White;
            labelCart.Location = new Point(0, 276);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(52, 30);
            labelCart.TabIndex = 6;
            labelCart.Text = "Cart";
            labelCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAccount
            // 
            labelAccount.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccount.ForeColor = Color.White;
            labelAccount.Location = new Point(0, 240);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(85, 30);
            labelAccount.TabIndex = 5;
            labelAccount.Text = "Account";
            labelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHome
            // 
            labelHome.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHome.ForeColor = Color.White;
            labelHome.Location = new Point(0, 204);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(75, 30);
            labelHome.TabIndex = 4;
            labelHome.Text = "Home";
            labelHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSearch
            // 
            labelSearch.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(0, 87);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(85, 30);
            labelSearch.TabIndex = 3;
            labelSearch.Text = "Search";
            labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(31, 31, 31);
            textBoxSearch.Location = new Point(0, 90);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(164, 27);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.Visible = false;
            textBoxSearch.Click += textBoxSearch_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(216, 27);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1029, 793);
            panelMain.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 3000;
            timer2.Tick += timer2_Tick;
            // 
            // FormMainScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1245, 820);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            Controls.Add(panelCollapsed);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Optimum Tech";
            panelTitleBar.ResumeLayout(false);
            panelCollapsed.ResumeLayout(false);
            panelSlide.ResumeLayout(false);
            panelSlide.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelCollapsed;
        private Panel panelSlide;
        private Panel panelMain;
        private Button buttonDrawer;
        private System.Windows.Forms.Timer timer1;
        private Button buttonClose;
        private Button buttonMinimize;
        private Button buttonCart;
        private System.Windows.Forms.Timer timer2;
        private Button buttonSettings;
        private Button buttonAccount;
        private Button buttonFavourites;
        private Button buttonMaximize;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Button buttonHome;
        private Label labelSearch;
        private Label labelSettings;
        private Label labelFavourites;
        private Label labelCart;
        private Label labelAccount;
        private Label labelHome;
        private Button buttonCategory;
        private Label labelCategory;
        private Button buttonAdmin;
        private Label labelAdmin;
        private Button buttonContact;
        private Label labelContact;
    }
}