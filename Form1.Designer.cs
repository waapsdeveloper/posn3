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
            logopanel = new Panel();
            header = new Panel();
            shutdown = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            deleterecord = new Button();
            editrecord = new Button();
            newrecord = new Button();
            panel2 = new Panel();
            topheading = new Label();
            searchbox = new TextBox();
            dashboardbutton = new Button();
            sidebar.SuspendLayout();
            header.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(2, 48, 71);
            sidebar.Controls.Add(dashboardbutton);
            sidebar.Controls.Add(logopanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(172, 450);
            sidebar.TabIndex = 0;
            sidebar.Paint += panel1_Paint;
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
            header.Controls.Add(shutdown);
            header.Dock = DockStyle.Top;
            header.Location = new Point(172, 0);
            header.Name = "header";
            header.Size = new Size(628, 36);
            header.TabIndex = 1;
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
            shutdown.Click += shutdownClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(172, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 36);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(deleterecord);
            flowLayoutPanel1.Controls.Add(editrecord);
            flowLayoutPanel1.Controls.Add(newrecord);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(369, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(259, 36);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // deleterecord
            // 
            deleterecord.Location = new Point(181, 3);
            deleterecord.Name = "deleterecord";
            deleterecord.Size = new Size(75, 23);
            deleterecord.TabIndex = 2;
            deleterecord.Text = "Delete";
            deleterecord.UseVisualStyleBackColor = true;
            deleterecord.Click += deleterecordClick;
            // 
            // editrecord
            // 
            editrecord.Location = new Point(100, 3);
            editrecord.Name = "editrecord";
            editrecord.Size = new Size(75, 23);
            editrecord.TabIndex = 1;
            editrecord.Text = "Edit";
            editrecord.UseVisualStyleBackColor = true;
            editrecord.Click += editrecordClick;
            // 
            // newrecord
            // 
            newrecord.Location = new Point(19, 3);
            newrecord.Name = "newrecord";
            newrecord.Size = new Size(75, 23);
            newrecord.TabIndex = 0;
            newrecord.Text = "New";
            newrecord.UseVisualStyleBackColor = true;
            newrecord.Click += newrecordClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(topheading);
            panel2.Controls.Add(searchbox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(172, 36);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 11, 0, 0);
            panel2.Size = new Size(628, 36);
            panel2.TabIndex = 3;
            // 
            // topheading
            // 
            topheading.AutoSize = true;
            topheading.Dock = DockStyle.Left;
            topheading.FlatStyle = FlatStyle.Flat;
            topheading.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            topheading.ForeColor = Color.FromArgb(2, 48, 71);
            topheading.Location = new Point(0, 11);
            topheading.Name = "topheading";
            topheading.Size = new Size(37, 15);
            topheading.TabIndex = 1;
            topheading.Text = "label1";
            topheading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchbox
            // 
            searchbox.Dock = DockStyle.Right;
            searchbox.Location = new Point(388, 11);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(240, 23);
            searchbox.TabIndex = 0;
            searchbox.Text = "Search ...";
            searchbox.TextChanged += textBox1_TextChanged;
            // 
            // dashboardbutton
            // 
            dashboardbutton.Dock = DockStyle.Top;
            dashboardbutton.FlatStyle = FlatStyle.Flat;
            dashboardbutton.ForeColor = Color.FromArgb(251, 133, 0);
            dashboardbutton.Location = new Point(0, 36);
            dashboardbutton.Margin = new Padding(0);
            dashboardbutton.Name = "dashboardbutton";
            dashboardbutton.Size = new Size(172, 36);
            dashboardbutton.TabIndex = 1;
            dashboardbutton.Text = "Dashboard";
            dashboardbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
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
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel header;
        private Panel logopanel;
        private Button shutdown;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button deleterecord;
        private Button editrecord;
        private Button newrecord;
        private Panel panel2;
        private TextBox searchbox;
        private Label topheading;
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
        private Button dashboardbutton;
    }
}