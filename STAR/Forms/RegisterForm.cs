using System;
using System.Windows.Forms;

namespace STAR.Forms
{
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm() { InitializeComponent(); }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            { MessageBox.Show("Complete all required fields.", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (passwordTextBox.Text != confirmTextBox.Text) { MessageBox.Show("Passwords do not match.", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Your account has been created.", "Welcome to STAR", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close();
        }
        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { Close(); }
    }
}
