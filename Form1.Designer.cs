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
            sidebar = new Panel();
            sidebaracountlist = new Button();
            sidebartaxlist = new Button();
            sidebarroles = new Button();
            sidebarusers = new Button();
            logopanel = new Panel();
            header = new Panel();
            button1 = new Button();
            shutdown = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            UserViewInPanel = new Views.UsersView();
            RoleViewInPanel = new Views.RolesView();
            TaxListViewInPanel = new Views.TaxListView();
            AccountListViewInPanel = new Views.AccountListView();
            AccountingViewInPanel = new Views.AccountingView();
            sidebaraccounting = new Button();
            sidebar.SuspendLayout();
            header.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(2, 48, 71);
            sidebar.Controls.Add(sidebaraccounting);
            sidebar.Controls.Add(sidebaracountlist);
            sidebar.Controls.Add(sidebartaxlist);
            sidebar.Controls.Add(sidebarroles);
            sidebar.Controls.Add(sidebarusers);
            sidebar.Controls.Add(logopanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(172, 450);
            sidebar.TabIndex = 0;
            sidebar.Paint += panel1_Paint;
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
            header.Controls.Add(button1);
            header.Controls.Add(shutdown);
            header.Dock = DockStyle.Top;
            header.Location = new Point(172, 0);
            header.Name = "header";
            header.Size = new Size(628, 36);
            header.TabIndex = 1;
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
            shutdown.Location = new Point(592, 0);
            shutdown.Margin = new Padding(0);
            shutdown.Name = "shutdown";
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
            panel1.Size = new Size(628, 414);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(UserViewInPanel);
            panel2.Controls.Add(RoleViewInPanel);
            panel2.Controls.Add(TaxListViewInPanel);
            panel2.Controls.Add(AccountListViewInPanel);
            panel2.Controls.Add(AccountingViewInPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 414);
            panel2.TabIndex = 2;
            // 
            // UserViewInPanel
            // 
            UserViewInPanel.AutoSize = true;
            UserViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            UserViewInPanel.Dock = DockStyle.Fill;
            UserViewInPanel.Location = new Point(0, 0);
            UserViewInPanel.Name = "UserViewInPanel";
            UserViewInPanel.Size = new Size(628, 414);
            UserViewInPanel.TabIndex = 0;
            // 
            // RoleViewInPanel
            // 
            RoleViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            RoleViewInPanel.Dock = DockStyle.Fill;
            RoleViewInPanel.Location = new Point(0, 0);
            RoleViewInPanel.Name = "RoleViewInPanel";
            RoleViewInPanel.Size = new Size(628, 414);
            RoleViewInPanel.TabIndex = 1;
            // 
            // TaxListViewInPanel
            // 
            TaxListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            TaxListViewInPanel.Dock = DockStyle.Fill;
            TaxListViewInPanel.Location = new Point(0, 0);
            TaxListViewInPanel.Name = "TaxListViewInPanel";
            TaxListViewInPanel.Size = new Size(628, 414);
            TaxListViewInPanel.TabIndex = 1;
            // 
            // AccountListViewInPanel
            // 
            AccountListViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            AccountListViewInPanel.Dock = DockStyle.Fill;
            AccountListViewInPanel.Location = new Point(0, 0);
            AccountListViewInPanel.Name = "AccountListViewInPanel";
            AccountListViewInPanel.Size = new Size(628, 414);
            AccountListViewInPanel.TabIndex = 1;

            // 
            // AccountingViewInPanel
            // 
            AccountingViewInPanel.BackColor = Color.FromArgb(254, 250, 224);
            AccountingViewInPanel.Dock = DockStyle.Fill;
            AccountingViewInPanel.Location = new Point(0, 0);
            AccountingViewInPanel.Name = "AccountingViewInPanel";
            AccountingViewInPanel.Size = new Size(628, 414);
            AccountingViewInPanel.TabIndex = 1;

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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(header);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            header.ResumeLayout(false);
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

        private Panel panel2;
        private Button sidebartaxlist;
        private Button sidebaracountlist;
        private Button sidebaraccounting;
    }
}