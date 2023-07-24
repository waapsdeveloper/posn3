namespace POSN3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidebar = new Panel();
            sidebarlogs = new Button();
            Login = new Button();
            sidebarmessages = new Button();
            sidebaremployeelist = new Button();
            sidebarinvoicelist = new Button();
            sidebarwarehouse = new Button();
            sidebarproducts = new Button();
            sidebargroups = new Button();
            sidebarpartnerlist = new Button();
            sidebaraccounting = new Button();
            sidebaracountlist = new Button();
            sidebartaxlist = new Button();
            sidebarroles = new Button();
            sidebarusers = new Button();
            logopanel = new Panel();
            header = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            shutdown = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            UserViewInPanel = new Views.UsersView();
            RoleViewInPanel = new Views.RolesView();
            TaxListViewInPanel = new Views.TaxListView();
            AccountListViewInPanel = new Views.AccountListView();
            AccountingViewInPanel = new Views.AccountingView();
            PartnerListViewInPanel = new Views.PartnerListView();
            GroupsViewInPanel = new Views.GroupsView();
            ProductsViewInPanel = new Views.ProductsView();
            WarehouseListViewInPanel = new Views.WarehouseListView();
            InvoiceListViewInPanel = new Views.InvoiceListView();
            EmployeeListViewInPanel = new Views.EmployeeListView();
            MessageListViewInPanel = new Views.MessageListView();
            UserControlViewInPanel = new Views.UserControl1();
            LogListViewInPanel = new Views.LogListView();
            sidebarpayments = new Button();
            sidebar.SuspendLayout();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(2, 48, 71);
            sidebar.Controls.Add(sidebarpayments);
            sidebar.Controls.Add(sidebarlogs);
            sidebar.Controls.Add(Login);
            sidebar.Controls.Add(sidebarmessages);
            sidebar.Controls.Add(sidebaremployeelist);
            sidebar.Controls.Add(sidebarinvoicelist);
            sidebar.Controls.Add(sidebarwarehouse);
            sidebar.Controls.Add(sidebarproducts);
            sidebar.Controls.Add(sidebargroups);
            sidebar.Controls.Add(sidebarpartnerlist);
            sidebar.Controls.Add(sidebaraccounting);
            sidebar.Controls.Add(sidebaracountlist);
            sidebar.Controls.Add(sidebartaxlist);
            sidebar.Controls.Add(sidebarroles);
            sidebar.Controls.Add(sidebarusers);
            sidebar.Controls.Add(logopanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(172, 658);
            sidebar.TabIndex = 0;
            sidebar.Paint += panel1_Paint;
            // 
            // sidebarlogs
            // 
            sidebarlogs.Dock = DockStyle.Top;
            sidebarlogs.FlatStyle = FlatStyle.Flat;
            sidebarlogs.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarlogs.Location = new Point(0, 504);
            sidebarlogs.Margin = new Padding(0);
            sidebarlogs.Name = "sidebarlogs";
            sidebarlogs.Size = new Size(172, 36);
            sidebarlogs.TabIndex = 15;
            sidebarlogs.Text = "Logs";
            sidebarlogs.UseVisualStyleBackColor = true;
            sidebarlogs.Click += sidebarlogs_Click;
            // 
            // Login
            // 
            Login.Dock = DockStyle.Top;
            Login.FlatStyle = FlatStyle.Flat;
            Login.ForeColor = Color.FromArgb(251, 133, 0);
            Login.Location = new Point(0, 468);
            Login.Margin = new Padding(0);
            Login.Name = "Login";
            Login.Size = new Size(172, 36);
            Login.TabIndex = 14;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // sidebarmessages
            // 
            sidebarmessages.Dock = DockStyle.Top;
            sidebarmessages.FlatStyle = FlatStyle.Flat;
            sidebarmessages.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarmessages.Location = new Point(0, 432);
            sidebarmessages.Margin = new Padding(0);
            sidebarmessages.Name = "sidebarmessages";
            sidebarmessages.Size = new Size(172, 36);
            sidebarmessages.TabIndex = 13;
            sidebarmessages.Text = "Messages";
            sidebarmessages.UseVisualStyleBackColor = true;
            sidebarmessages.Click += sidebarmessages_Click;
            // 
            // sidebaremployeelist
            // 
            sidebaremployeelist.Dock = DockStyle.Top;
            sidebaremployeelist.FlatStyle = FlatStyle.Flat;
            sidebaremployeelist.ForeColor = Color.FromArgb(251, 133, 0);
            sidebaremployeelist.Location = new Point(0, 396);
            sidebaremployeelist.Margin = new Padding(0);
            sidebaremployeelist.Name = "sidebaremployeelist";
            sidebaremployeelist.Size = new Size(172, 36);
            sidebaremployeelist.TabIndex = 12;
            sidebaremployeelist.Text = "Employees";
            sidebaremployeelist.UseVisualStyleBackColor = true;
            sidebaremployeelist.Click += sidebaremployeelist_Click;
            // 
            // sidebarinvoicelist
            // 
            sidebarinvoicelist.Dock = DockStyle.Top;
            sidebarinvoicelist.FlatStyle = FlatStyle.Flat;
            sidebarinvoicelist.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarinvoicelist.Location = new Point(0, 360);
            sidebarinvoicelist.Margin = new Padding(0);
            sidebarinvoicelist.Name = "sidebarinvoicelist";
            sidebarinvoicelist.Size = new Size(172, 36);
            sidebarinvoicelist.TabIndex = 11;
            sidebarinvoicelist.Text = "Invoices";
            sidebarinvoicelist.UseVisualStyleBackColor = true;
            sidebarinvoicelist.Click += sidebarinvoicelist_Click;
            // 
            // sidebarwarehouse
            // 
            sidebarwarehouse.Dock = DockStyle.Top;
            sidebarwarehouse.FlatStyle = FlatStyle.Flat;
            sidebarwarehouse.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarwarehouse.Location = new Point(0, 324);
            sidebarwarehouse.Margin = new Padding(0);
            sidebarwarehouse.Name = "sidebarwarehouse";
            sidebarwarehouse.Size = new Size(172, 36);
            sidebarwarehouse.TabIndex = 10;
            sidebarwarehouse.Text = "Warehouses";
            sidebarwarehouse.UseVisualStyleBackColor = true;
            sidebarwarehouse.Click += sidebarwarehouse_Click;
            // 
            // sidebarproducts
            // 
            sidebarproducts.Dock = DockStyle.Top;
            sidebarproducts.FlatStyle = FlatStyle.Flat;
            sidebarproducts.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarproducts.Location = new Point(0, 288);
            sidebarproducts.Margin = new Padding(0);
            sidebarproducts.Name = "sidebarproducts";
            sidebarproducts.Size = new Size(172, 36);
            sidebarproducts.TabIndex = 9;
            sidebarproducts.Text = "Products";
            sidebarproducts.UseVisualStyleBackColor = true;
            sidebarproducts.Click += sidebarproducts_Click;
            // 
            // sidebargroups
            // 
            sidebargroups.Dock = DockStyle.Top;
            sidebargroups.FlatStyle = FlatStyle.Flat;
            sidebargroups.ForeColor = Color.FromArgb(251, 133, 0);
            sidebargroups.Location = new Point(0, 252);
            sidebargroups.Margin = new Padding(0);
            sidebargroups.Name = "sidebargroups";
            sidebargroups.Size = new Size(172, 36);
            sidebargroups.TabIndex = 8;
            sidebargroups.Text = "Groups";
            sidebargroups.UseVisualStyleBackColor = true;
            sidebargroups.Click += sidebargroups_Click;
            // 
            // sidebarpartnerlist
            // 
            sidebarpartnerlist.Dock = DockStyle.Top;
            sidebarpartnerlist.FlatStyle = FlatStyle.Flat;
            sidebarpartnerlist.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarpartnerlist.Location = new Point(0, 216);
            sidebarpartnerlist.Margin = new Padding(0);
            sidebarpartnerlist.Name = "sidebarpartnerlist";
            sidebarpartnerlist.Size = new Size(172, 36);
            sidebarpartnerlist.TabIndex = 7;
            sidebarpartnerlist.Text = "Partner List";
            sidebarpartnerlist.UseVisualStyleBackColor = true;
            sidebarpartnerlist.Click += sidebarpartnerlist_Click;
            // 
            // sidebaraccounting
            // 
            sidebaraccounting.Dock = DockStyle.Top;
            sidebaraccounting.FlatStyle = FlatStyle.Flat;
            sidebaraccounting.ForeColor = Color.FromArgb(251, 133, 0);
            sidebaraccounting.Location = new Point(0, 180);
            sidebaraccounting.Margin = new Padding(0);
            sidebaraccounting.Name = "sidebaraccounting";
            sidebaraccounting.Size = new Size(172, 36);
            sidebaraccounting.TabIndex = 6;
            sidebaraccounting.Text = "Accounting";
            sidebaraccounting.UseVisualStyleBackColor = true;
            sidebaraccounting.Click += sidebaraccounting_Click;
            // 
            // sidebaracountlist
            // 
            sidebaracountlist.Dock = DockStyle.Top;
            sidebaracountlist.FlatStyle = FlatStyle.Flat;
            sidebaracountlist.ForeColor = Color.FromArgb(251, 133, 0);
            sidebaracountlist.Location = new Point(0, 144);
            sidebaracountlist.Margin = new Padding(0);
            sidebaracountlist.Name = "sidebaracountlist";
            sidebaracountlist.Size = new Size(172, 36);
            sidebaracountlist.TabIndex = 5;
            sidebaracountlist.Text = "Account List";
            sidebaracountlist.UseVisualStyleBackColor = true;
            sidebaracountlist.Click += sidebaracountlist_Click;
            // 
            // sidebartaxlist
            // 
            sidebartaxlist.Dock = DockStyle.Top;
            sidebartaxlist.FlatStyle = FlatStyle.Flat;
            sidebartaxlist.ForeColor = Color.FromArgb(251, 133, 0);
            sidebartaxlist.Location = new Point(0, 108);
            sidebartaxlist.Margin = new Padding(0);
            sidebartaxlist.Name = "sidebartaxlist";
            sidebartaxlist.Size = new Size(172, 36);
            sidebartaxlist.TabIndex = 4;
            sidebartaxlist.Text = "Tax List";
            sidebartaxlist.UseVisualStyleBackColor = true;
            sidebartaxlist.Click += sidebartaxlist_Click;
            // 
            // sidebarroles
            // 
            sidebarroles.Dock = DockStyle.Top;
            sidebarroles.FlatStyle = FlatStyle.Flat;
            sidebarroles.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarroles.Location = new Point(0, 72);
            sidebarroles.Margin = new Padding(0);
            sidebarroles.Name = "sidebarroles";
            sidebarroles.Size = new Size(172, 36);
            sidebarroles.TabIndex = 3;
            sidebarroles.Text = "Roles";
            sidebarroles.UseVisualStyleBackColor = true;
            sidebarroles.Click += sidebarroles_Click;
            // 
            // sidebarusers
            // 
            sidebarusers.Dock = DockStyle.Top;
            sidebarusers.FlatStyle = FlatStyle.Flat;
            sidebarusers.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarusers.Location = new Point(0, 36);
            sidebarusers.Margin = new Padding(0);
            sidebarusers.Name = "sidebarusers";
            sidebarusers.Size = new Size(172, 36);
            sidebarusers.TabIndex = 2;
            sidebarusers.Text = "Users";
            sidebarusers.UseVisualStyleBackColor = true;
            sidebarusers.Click += sidebarusers_Click;
            // 
            // logopanel
            // 
            logopanel.BackColor = Color.FromArgb(251, 133, 0);
            logopanel.Dock = DockStyle.Top;
            logopanel.Location = new Point(0, 0);
            logopanel.Name = "logopanel";
            logopanel.Size = new Size(172, 36);
            logopanel.TabIndex = 0;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(254, 250, 224);
            header.Controls.Add(label1);
            header.Controls.Add(pictureBox1);
            header.Controls.Add(button1);
            header.Controls.Add(shutdown);
            header.Dock = DockStyle.Top;
            header.Location = new Point(172, 0);
            header.Name = "header";
            header.Size = new Size(628, 36);
            header.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(52, 10);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(6);
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(254, 250, 224);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(254, 250, 224);
            button1.Location = new Point(556, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(36, 36);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // shutdown
            // 
            shutdown.BackColor = Color.FromArgb(251, 133, 0);
            shutdown.BackgroundImageLayout = ImageLayout.None;
            shutdown.Dock = DockStyle.Right;
            shutdown.FlatStyle = FlatStyle.Flat;
            shutdown.ForeColor = Color.FromArgb(251, 133, 0);
            shutdown.Image = (Image)resources.GetObject("shutdown.Image");
            shutdown.Location = new Point(592, 0);
            shutdown.Margin = new Padding(0);
            shutdown.Name = "shutdown";
            shutdown.Padding = new Padding(5);
            shutdown.Size = new Size(36, 36);
            shutdown.TabIndex = 0;
            shutdown.UseVisualStyleBackColor = false;
            shutdown.Click += shutdown_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(172, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 622);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(UserViewInPanel);
            panel2.Controls.Add(RoleViewInPanel);
            panel2.Controls.Add(TaxListViewInPanel);
            panel2.Controls.Add(AccountListViewInPanel);
            panel2.Controls.Add(AccountingViewInPanel);
            panel2.Controls.Add(PartnerListViewInPanel);
            panel2.Controls.Add(GroupsViewInPanel);
            panel2.Controls.Add(ProductsViewInPanel);
            panel2.Controls.Add(WarehouseListViewInPanel);
            panel2.Controls.Add(InvoiceListViewInPanel);
            panel2.Controls.Add(EmployeeListViewInPanel);
            panel2.Controls.Add(MessageListViewInPanel);
            panel2.Controls.Add(UserControlViewInPanel);
            panel2.Controls.Add(LogListViewInPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 622);
            panel2.TabIndex = 2;
            // 
            // UserViewInPanel
            // 
            UserViewInPanel.AutoSize = true;
            UserViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            UserViewInPanel.Dock = DockStyle.Fill;
            UserViewInPanel.Location = new Point(0, 0);
            UserViewInPanel.Name = "UserViewInPanel";
            UserViewInPanel.Size = new Size(628, 622);
            UserViewInPanel.TabIndex = 0;
            UserViewInPanel.Load += UserViewInPanel_Load;
            // 
            // RoleViewInPanel
            // 
            RoleViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            RoleViewInPanel.Dock = DockStyle.Fill;
            RoleViewInPanel.Location = new Point(0, 0);
            RoleViewInPanel.Name = "RoleViewInPanel";
            RoleViewInPanel.Size = new Size(628, 622);
            RoleViewInPanel.TabIndex = 1;
            // 
            // TaxListViewInPanel
            // 
            TaxListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            TaxListViewInPanel.Dock = DockStyle.Fill;
            TaxListViewInPanel.Location = new Point(0, 0);
            TaxListViewInPanel.Name = "TaxListViewInPanel";
            TaxListViewInPanel.Size = new Size(628, 622);
            TaxListViewInPanel.TabIndex = 1;
            // 
            // AccountListViewInPanel
            // 
            AccountListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            AccountListViewInPanel.Dock = DockStyle.Fill;
            AccountListViewInPanel.Location = new Point(0, 0);
            AccountListViewInPanel.Name = "AccountListViewInPanel";
            AccountListViewInPanel.Size = new Size(628, 622);
            AccountListViewInPanel.TabIndex = 1;
            // 
            // AccountingViewInPanel
            // 
            AccountingViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            AccountingViewInPanel.Dock = DockStyle.Fill;
            AccountingViewInPanel.Location = new Point(0, 0);
            AccountingViewInPanel.Name = "AccountingViewInPanel";
            AccountingViewInPanel.Size = new Size(628, 622);
            AccountingViewInPanel.TabIndex = 1;
            // 
            // PartnerListViewInPanel
            // 
            PartnerListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            PartnerListViewInPanel.Dock = DockStyle.Fill;
            PartnerListViewInPanel.Location = new Point(0, 0);
            PartnerListViewInPanel.Name = "PartnerListViewInPanel";
            PartnerListViewInPanel.Size = new Size(628, 622);
            PartnerListViewInPanel.TabIndex = 1;
            // 
            // GroupsViewInPanel
            // 
            GroupsViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            GroupsViewInPanel.Dock = DockStyle.Fill;
            GroupsViewInPanel.Location = new Point(0, 0);
            GroupsViewInPanel.Name = "GroupsViewInPanel";
            GroupsViewInPanel.Size = new Size(628, 622);
            GroupsViewInPanel.TabIndex = 1;
            // 
            // ProductsViewInPanel
            // 
            ProductsViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            ProductsViewInPanel.Dock = DockStyle.Fill;
            ProductsViewInPanel.Location = new Point(0, 0);
            ProductsViewInPanel.Name = "ProductsViewInPanel";
            ProductsViewInPanel.Size = new Size(628, 622);
            ProductsViewInPanel.TabIndex = 1;
            // 
            // WarehouseListViewInPanel
            // 
            WarehouseListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            WarehouseListViewInPanel.Dock = DockStyle.Fill;
            WarehouseListViewInPanel.Location = new Point(0, 0);
            WarehouseListViewInPanel.Name = "WarehouseListViewInPanel";
            WarehouseListViewInPanel.Size = new Size(628, 622);
            WarehouseListViewInPanel.TabIndex = 1;
            // 
            // InvoiceListViewInPanel
            // 
            InvoiceListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            InvoiceListViewInPanel.Dock = DockStyle.Fill;
            InvoiceListViewInPanel.Location = new Point(0, 0);
            InvoiceListViewInPanel.Name = "InvoiceListViewInPanel";
            InvoiceListViewInPanel.Size = new Size(628, 622);
            InvoiceListViewInPanel.TabIndex = 1;
            // 
            // EmployeeListViewInPanel
            // 
            EmployeeListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            EmployeeListViewInPanel.Dock = DockStyle.Fill;
            EmployeeListViewInPanel.Location = new Point(0, 0);
            EmployeeListViewInPanel.Name = "EmployeeListViewInPanel";
            EmployeeListViewInPanel.Size = new Size(628, 622);
            EmployeeListViewInPanel.TabIndex = 1;
            // 
            // MessageListViewInPanel
            // 
            MessageListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            MessageListViewInPanel.Dock = DockStyle.Fill;
            MessageListViewInPanel.Location = new Point(0, 0);
            MessageListViewInPanel.Name = "MessageListViewInPanel";
            MessageListViewInPanel.Size = new Size(628, 622);
            MessageListViewInPanel.TabIndex = 1;
            // 
            // UserControlViewInPanel
            // 
            UserControlViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            UserControlViewInPanel.Dock = DockStyle.Fill;
            UserControlViewInPanel.Location = new Point(0, 0);
            UserControlViewInPanel.Name = "UserControlViewInPanel";
            UserControlViewInPanel.Size = new Size(628, 622);
            UserControlViewInPanel.TabIndex = 1;
            // 
            // LogListViewInPanel
            // 
            LogListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            LogListViewInPanel.Dock = DockStyle.Fill;
            LogListViewInPanel.Location = new Point(0, 0);
            LogListViewInPanel.Name = "LogListViewInPanel";
            LogListViewInPanel.Size = new Size(628, 622);
            LogListViewInPanel.TabIndex = 1;
            // 
            // sidebarpayments
            // 
            sidebarpayments.Dock = DockStyle.Top;
            sidebarpayments.FlatStyle = FlatStyle.Flat;
            sidebarpayments.ForeColor = Color.FromArgb(251, 133, 0);
            sidebarpayments.Location = new Point(0, 540);
            sidebarpayments.Margin = new Padding(0);
            sidebarpayments.Name = "sidebarpayments";
            sidebarpayments.Size = new Size(172, 36);
            sidebarpayments.TabIndex = 16;
            sidebarpayments.Text = "Payments";
            sidebarpayments.UseVisualStyleBackColor = true;
            sidebarpayments.Click += sidebarpayments_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 658);
            Controls.Add(panel1);
            Controls.Add(header);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel header;
        private Panel logopanel;
        private Button shutdown;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button sidebarusers;
        private Button sidebarroles;
        private Panel panel1;
        private Views.RolesView RoleViewInPanel;
        private Views.UsersView UserViewInPanel;
        private Views.TaxListView TaxListViewInPanel;
        private Views.AccountListView AccountListViewInPanel;
        private Views.AccountingView AccountingViewInPanel;
        private Views.PartnerListView PartnerListViewInPanel;
        private Views.GroupsView GroupsViewInPanel;
        private Views.ProductsView ProductsViewInPanel;
        private Views.WarehouseListView WarehouseListViewInPanel;
        private Views.InvoiceListView InvoiceListViewInPanel;
        private Views.EmployeeListView EmployeeListViewInPanel;
        private Views.MessageListView MessageListViewInPanel;
        private Views.UserControl1 UserControlViewInPanel;
        private Views.LogListView LogListViewInPanel;
        private Panel panel2;
        private Button sidebartaxlist;
        private Button sidebaracountlist;
        private Button sidebaraccounting;
        private Button sidebarpartnerlist;
        private Button sidebargroups;
        private Button sidebarproducts;
        private Button sidebarwarehouse;
        private Button sidebarinvoicelist;
        private Button sidebaremployeelist;
        private Button sidebarmessages;
        private Button Login;
        private PictureBox pictureBox1;
        private Label label1;
        private Button sidebarlogs;
        private Button sidebarpayments;
    }
}