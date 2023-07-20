using POSN3.Helpers.ModelHelpers;
using POSN3.Helpers;

namespace POSN3.Views
{
    partial class UserControl1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;

        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(50, 59);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(50, 118);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(251, 133, 0);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(50, 159);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 30);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(50, 41);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter email address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(50, 100);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter password";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 71);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);
            Name = "UserControl1";
            Size = new Size(757, 481);
            ResumeLayout(false);
            PerformLayout();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Perform the login authentication logic here
            // You can implement your own login logic or call a login service

            SqliteHelper sqliteHelper = new SqliteHelper();
            ControlHelper helper = new ControlHelper(sqliteHelper);

            bool auth = await helper.authenticate(username, password);

            if (auth)
            {
                Form1 form1 = this.ParentForm as Form1;
                if (form1 != null)
                {
                    form1.loginSuccessful();
                } else
                {
                    MessageBox.Show("Invalid login credentials. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }









        }

        private Label label1;
        private Label label2;
    }
}
