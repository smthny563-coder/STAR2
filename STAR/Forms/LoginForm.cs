using System;
using System.Windows.Forms;

namespace STAR.Forms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Enter your username and password.", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hide();
            using (var feed = new FeedForm()) feed.ShowDialog(this);
            Show();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var register = new RegisterForm()) register.ShowDialog(this);
        }

        private void forgotLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var forgot = new ForgotPasswordForm()) forgot.ShowDialog(this);
        }
    }
}
