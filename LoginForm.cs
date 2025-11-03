using System;
using System.Windows.Forms;

namespace InsightAttend
{
    public class LoginForm : Form
    {
        private Label lblUser, lblPass;
        private TextBox txtUser, txtPass;
        private Button btnLogin;

        public LoginForm()
        {
            Text = "InsightAttend - Login";
            Width = 360;
            Height = 200;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            lblUser = new Label(){ Left = 20, Top = 20, Text = "Username", AutoSize = true };
            txtUser = new TextBox(){ Left = 120, Top = 18, Width = 180, Text = "admin" };

            lblPass = new Label(){ Left = 20, Top = 60, Text = "Password", AutoSize = true };
            txtPass = new TextBox(){ Left = 120, Top = 58, Width = 180, UseSystemPasswordChar = true, Text = "admin" };

            btnLogin = new Button(){ Left = 120, Top = 100, Width = 100, Text = "Login" };
            btnLogin.Click += BtnLogin_Click;

            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                Hide();
                var main = new MainForm();
                main.FormClosed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Use admin/admin for now.", "Login failed");
            }
        }
    }
}
