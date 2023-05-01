using Optimum_Tech.View.Resources;
using OptimumTech;

namespace Optimum_Tech.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            buttonFavorites = new Button();
            buttonCart = new Button();
            panelSlide = new Panel();
            textBoxDrawer = new TextBox();
            textBoxSearchText = new TextBox();
            textBoxCategories = new TextBox();
            textBoxHome = new TextBox();
            textBoxAccount = new TextBox();
            textBoxCart = new TextBox();
            textBoxFavorites = new TextBox();
            textBoxContact = new TextBox();
            textBoxAdmin = new TextBox();
            textBoxSettings = new TextBox();
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
            panelTitleBar.BackColor = Color.FromArgb(20, 20, 20);
            panelTitleBar.Controls.Add(buttonMinimize);
            panelTitleBar.Controls.Add(buttonClose);
            panelTitleBar.Controls.Add(buttonMaximize);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1320, 27);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            panelTitleBar.MouseMove += panelTitleBar_MouseMove;
            panelTitleBar.MouseUp += panelTitleBar_MouseUp;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = FormsMedia.minimize;
            buttonMinimize.Location = new Point(1233, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(25, 27);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = FormsMedia.close;
            buttonClose.Location = new Point(1295, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(25, 27);
            buttonClose.TabIndex = 0;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.ForeColor = Color.White;
            buttonMaximize.Image = FormsMedia.maximize;
            buttonMaximize.Location = new Point(1264, 0);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(25, 27);
            buttonMaximize.TabIndex = 0;
            buttonMaximize.UseVisualStyleBackColor = true;
            buttonMaximize.Click += buttonMaximize_Click;
            // 
            // panelCollapsed
            // 
            panelCollapsed.BackColor = Color.FromArgb(30, 30, 30);
            panelCollapsed.Controls.Add(buttonDrawer);
            panelCollapsed.Controls.Add(buttonSearch);
            panelCollapsed.Controls.Add(buttonAdmin);
            panelCollapsed.Controls.Add(buttonCategory);
            panelCollapsed.Controls.Add(buttonSettings);
            panelCollapsed.Controls.Add(buttonContact);
            panelCollapsed.Controls.Add(buttonHome);
            panelCollapsed.Controls.Add(buttonAccount);
            panelCollapsed.Controls.Add(buttonFavorites);
            panelCollapsed.Controls.Add(buttonCart);
            panelCollapsed.Dock = DockStyle.Left;
            panelCollapsed.Location = new Point(0, 27);
            panelCollapsed.Name = "panelCollapsed";
            panelCollapsed.Size = new Size(45, 739);
            panelCollapsed.TabIndex = 1;
            // 
            // buttonDrawer
            // 
            buttonDrawer.FlatAppearance.BorderSize = 0;
            buttonDrawer.FlatStyle = FlatStyle.Flat;
            buttonDrawer.Image = FormsMedia.drawer;
            buttonDrawer.Location = new Point(0, 27);
            buttonDrawer.Name = "buttonDrawer";
            buttonDrawer.Size = new Size(45, 30);
            buttonDrawer.TabIndex = 0;
            buttonDrawer.UseVisualStyleBackColor = true;
            buttonDrawer.Click += buttonDrawer_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.AutoSize = true;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = SystemColors.ControlText;
            buttonSearch.Image = FormsMedia.search;
            buttonSearch.Location = new Point(0, 88);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(45, 30);
            buttonSearch.TabIndex = 0;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdmin.AutoSize = true;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Image = FormsMedia.admin;
            buttonAdmin.Location = new Point(0, 610);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(45, 30);
            buttonAdmin.TabIndex = 10;
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Visible = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.AutoSize = true;
            buttonCategory.FlatAppearance.BorderSize = 0;
            buttonCategory.FlatStyle = FlatStyle.Flat;
            buttonCategory.Image = FormsMedia.category;
            buttonCategory.Location = new Point(0, 168);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(45, 30);
            buttonCategory.TabIndex = 0;
            buttonCategory.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSettings.AutoSize = true;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Image = FormsMedia.settings;
            buttonSettings.Location = new Point(0, 682);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(45, 30);
            buttonSettings.TabIndex = 0;
            buttonSettings.TextAlign = ContentAlignment.MiddleRight;
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonContact
            // 
            buttonContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonContact.AutoSize = true;
            buttonContact.FlatAppearance.BorderSize = 0;
            buttonContact.FlatStyle = FlatStyle.Flat;
            buttonContact.Image = FormsMedia.contact;
            buttonContact.Location = new Point(0, 646);
            buttonContact.Name = "buttonContact";
            buttonContact.Size = new Size(45, 30);
            buttonContact.TabIndex = 0;
            buttonContact.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.AutoSize = true;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Image = FormsMedia.home;
            buttonHome.Location = new Point(0, 204);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(45, 30);
            buttonHome.TabIndex = 0;
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonAccount
            // 
            buttonAccount.AutoSize = true;
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Image = FormsMedia.account;
            buttonAccount.Location = new Point(0, 240);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(45, 30);
            buttonAccount.TabIndex = 0;
            buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonFavorites
            // 
            buttonFavorites.AutoSize = true;
            buttonFavorites.FlatAppearance.BorderSize = 0;
            buttonFavorites.FlatStyle = FlatStyle.Flat;
            buttonFavorites.Image = FormsMedia.favorite;
            buttonFavorites.Location = new Point(0, 312);
            buttonFavorites.Name = "buttonFavorites";
            buttonFavorites.Size = new Size(45, 30);
            buttonFavorites.TabIndex = 0;
            buttonFavorites.UseVisualStyleBackColor = true;
            buttonFavorites.Click += buttonFavorites_Click;
            // 
            // buttonCart
            // 
            buttonCart.AutoSize = true;
            buttonCart.FlatAppearance.BorderSize = 0;
            buttonCart.FlatStyle = FlatStyle.Flat;
            buttonCart.Image = FormsMedia.cart;
            buttonCart.Location = new Point(0, 276);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(45, 30);
            buttonCart.TabIndex = 0;
            buttonCart.UseVisualStyleBackColor = true;
            buttonCart.Click += buttonCart_Click;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.FromArgb(40, 40, 40);
            panelSlide.Controls.Add(textBoxDrawer);
            panelSlide.Controls.Add(textBoxSearchText);
            panelSlide.Controls.Add(textBoxCategories);
            panelSlide.Controls.Add(textBoxHome);
            panelSlide.Controls.Add(textBoxAccount);
            panelSlide.Controls.Add(textBoxCart);
            panelSlide.Controls.Add(textBoxFavorites);
            panelSlide.Controls.Add(textBoxContact);
            panelSlide.Controls.Add(textBoxAdmin);
            panelSlide.Controls.Add(textBoxSettings);
            panelSlide.Controls.Add(textBoxSearch);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(45, 27);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(163, 739);
            panelSlide.TabIndex = 2;
            // 
            // textBoxDrawer
            // 
            textBoxDrawer.BackColor = Color.FromArgb(40, 40, 40);
            textBoxDrawer.BorderStyle = BorderStyle.None;
            textBoxDrawer.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDrawer.ForeColor = Color.White;
            textBoxDrawer.Location = new Point(6, 29);
            textBoxDrawer.Name = "textBoxDrawer";
            textBoxDrawer.ReadOnly = true;
            textBoxDrawer.Size = new Size(100, 24);
            textBoxDrawer.TabIndex = 21;
            textBoxDrawer.Text = "Drawer";
            // 
            // textBoxSearchText
            // 
            textBoxSearchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchText.BackColor = SystemColors.Control;
            textBoxSearchText.BorderStyle = BorderStyle.None;
            textBoxSearchText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchText.ForeColor = Color.FromArgb(20, 20, 20);
            textBoxSearchText.Location = new Point(6, 94);
            textBoxSearchText.Name = "textBoxSearchText";
            textBoxSearchText.Size = new Size(151, 24);
            textBoxSearchText.TabIndex = 20;
            textBoxSearchText.Text = "Search";
            textBoxSearchText.Enter += textBoxSearchText_Enter;
            // 
            // textBoxCategories
            // 
            textBoxCategories.BackColor = Color.FromArgb(40, 40, 40);
            textBoxCategories.BorderStyle = BorderStyle.None;
            textBoxCategories.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategories.ForeColor = Color.White;
            textBoxCategories.Location = new Point(6, 174);
            textBoxCategories.Name = "textBoxCategories";
            textBoxCategories.ReadOnly = true;
            textBoxCategories.Size = new Size(100, 24);
            textBoxCategories.TabIndex = 19;
            textBoxCategories.Text = "Categories";
            // 
            // textBoxHome
            // 
            textBoxHome.BackColor = Color.FromArgb(40, 40, 40);
            textBoxHome.BorderStyle = BorderStyle.None;
            textBoxHome.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHome.ForeColor = Color.White;
            textBoxHome.Location = new Point(6, 210);
            textBoxHome.Name = "textBoxHome";
            textBoxHome.ReadOnly = true;
            textBoxHome.Size = new Size(100, 24);
            textBoxHome.TabIndex = 18;
            textBoxHome.Text = "Home";
            // 
            // textBoxAccount
            // 
            textBoxAccount.BackColor = Color.FromArgb(40, 40, 40);
            textBoxAccount.BorderStyle = BorderStyle.None;
            textBoxAccount.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccount.ForeColor = Color.White;
            textBoxAccount.Location = new Point(6, 246);
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.ReadOnly = true;
            textBoxAccount.Size = new Size(100, 24);
            textBoxAccount.TabIndex = 17;
            textBoxAccount.Text = "Account";
            // 
            // textBoxCart
            // 
            textBoxCart.BackColor = Color.FromArgb(40, 40, 40);
            textBoxCart.BorderStyle = BorderStyle.None;
            textBoxCart.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCart.ForeColor = Color.White;
            textBoxCart.Location = new Point(6, 282);
            textBoxCart.Name = "textBoxCart";
            textBoxCart.ReadOnly = true;
            textBoxCart.Size = new Size(100, 24);
            textBoxCart.TabIndex = 16;
            textBoxCart.Text = "Cart";
            // 
            // textBoxFavorites
            // 
            textBoxFavorites.BackColor = Color.FromArgb(40, 40, 40);
            textBoxFavorites.BorderStyle = BorderStyle.None;
            textBoxFavorites.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFavorites.ForeColor = Color.White;
            textBoxFavorites.Location = new Point(6, 318);
            textBoxFavorites.Name = "textBoxFavorites";
            textBoxFavorites.ReadOnly = true;
            textBoxFavorites.Size = new Size(100, 24);
            textBoxFavorites.TabIndex = 15;
            textBoxFavorites.Text = "Favorites";
            // 
            // textBoxContact
            // 
            textBoxContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxContact.BackColor = Color.FromArgb(40, 40, 40);
            textBoxContact.BorderStyle = BorderStyle.None;
            textBoxContact.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContact.ForeColor = Color.White;
            textBoxContact.Location = new Point(6, 652);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.ReadOnly = true;
            textBoxContact.Size = new Size(100, 24);
            textBoxContact.TabIndex = 14;
            textBoxContact.Text = "Contact";
            // 
            // textBoxAdmin
            // 
            textBoxAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxAdmin.BackColor = Color.FromArgb(40, 40, 40);
            textBoxAdmin.BorderStyle = BorderStyle.None;
            textBoxAdmin.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdmin.ForeColor = Color.White;
            textBoxAdmin.Location = new Point(6, 616);
            textBoxAdmin.Name = "textBoxAdmin";
            textBoxAdmin.ReadOnly = true;
            textBoxAdmin.Size = new Size(100, 24);
            textBoxAdmin.TabIndex = 13;
            textBoxAdmin.Text = "Admin";
            textBoxAdmin.Visible = false;
            // 
            // textBoxSettings
            // 
            textBoxSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSettings.BackColor = Color.FromArgb(40, 40, 40);
            textBoxSettings.BorderStyle = BorderStyle.None;
            textBoxSettings.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSettings.ForeColor = Color.White;
            textBoxSettings.Location = new Point(6, 688);
            textBoxSettings.Name = "textBoxSettings";
            textBoxSettings.ReadOnly = true;
            textBoxSettings.Size = new Size(100, 24);
            textBoxSettings.TabIndex = 12;
            textBoxSettings.Text = "Settings";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BackColor = Color.FromArgb(40, 40, 40);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(27, 27, 27);
            textBoxSearch.Location = new Point(6, 94);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.ReadOnly = true;
            textBoxSearch.Size = new Size(151, 24);
            textBoxSearch.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Control;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(208, 27);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1112, 739);
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
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1320, 766);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            Controls.Add(panelCollapsed);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Optimum Tech";
            Load += FormMain_Load;
            panelTitleBar.ResumeLayout(false);
            panelCollapsed.ResumeLayout(false);
            panelCollapsed.PerformLayout();
            panelSlide.ResumeLayout(false);
            panelSlide.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelCollapsed;
        private Panel panelSlide;
        internal Panel panelMain;
        private Button buttonDrawer;
        private System.Windows.Forms.Timer timer1;
        private Button buttonClose;
        private Button buttonMinimize;
        private System.Windows.Forms.Timer timer2;
        private Button buttonSettings;
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
        private Label labelAdmin;
        private Button buttonContact;
        private Label labelContact;
        private TextBox textBoxSettings;
        private TextBox textBoxCategories;
        private TextBox textBoxHome;
        private TextBox textBoxAccount;
        private TextBox textBoxContact;
        private TextBox textBoxDrawer;
        private Button buttonAccount;

        public Button buttonFavorites;
        public TextBox textBoxFavorites;

        public TextBox textBoxCart;
        public Button buttonCart;

        public Button buttonAdmin;
        public TextBox textBoxAdmin;

        public TextBox textBoxSearchText;
    }
}



