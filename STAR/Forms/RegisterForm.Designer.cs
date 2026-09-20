using System.Drawing;
using System.Windows.Forms;

namespace STAR.Forms
{
    partial class RegisterForm
    {
        private Label logoLabel, headingLabel, nameLabel, emailLabel, passwordLabel, confirmLabel;
        private TextBox nameTextBox, emailTextBox, passwordTextBox, confirmTextBox;
        private Button registerButton; private LinkLabel loginLink;
        private void InitializeComponent()
        {
            logoLabel = new Label(); headingLabel = new Label(); nameLabel = new Label(); emailLabel = new Label(); passwordLabel = new Label(); confirmLabel = new Label();
            nameTextBox = new TextBox(); emailTextBox = new TextBox(); passwordTextBox = new TextBox(); confirmTextBox = new TextBox(); registerButton = new Button(); loginLink = new LinkLabel(); SuspendLayout();
            logoLabel.AutoSize = true; logoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold); logoLabel.ForeColor = Gold; logoLabel.Location = new Point(320, 25); logoLabel.Text = "STAR";
            headingLabel.AutoSize = true; headingLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold); headingLabel.Location = new Point(278, 82); headingLabel.Text = "Create your account";
            nameLabel.AutoSize = true; nameLabel.Location = new Point(205, 130); nameLabel.Text = "Display name *"; nameTextBox.Location = new Point(205, 153); nameTextBox.Size = new Size(350, 25);
            emailLabel.AutoSize = true; emailLabel.Location = new Point(205, 190); emailLabel.Text = "Email *"; emailTextBox.Location = new Point(205, 213); emailTextBox.Size = new Size(350, 25);
            passwordLabel.AutoSize = true; passwordLabel.Location = new Point(205, 250); passwordLabel.Text = "Password *"; passwordTextBox.Location = new Point(205, 273); passwordTextBox.Size = new Size(350, 25); passwordTextBox.UseSystemPasswordChar = true;
            confirmLabel.AutoSize = true; confirmLabel.Location = new Point(205, 310); confirmLabel.Text = "Confirm password *"; confirmTextBox.Location = new Point(205, 333); confirmTextBox.Size = new Size(350, 25); confirmTextBox.UseSystemPasswordChar = true;
            registerButton.Location = new Point(205, 385); registerButton.Size = new Size(350, 40); registerButton.Text = "CREATE ACCOUNT"; StyleButton(registerButton); registerButton.Click += registerButton_Click;
            loginLink.AutoSize = true; loginLink.LinkColor = Gold; loginLink.Location = new Point(300, 445); loginLink.Text = "Already have an account? Sign in"; loginLink.LinkClicked += loginLink_LinkClicked;
            Controls.AddRange(new Control[] { logoLabel, headingLabel, nameLabel, nameTextBox, emailLabel, emailTextBox, passwordLabel, passwordTextBox, confirmLabel, confirmTextBox, registerButton, loginLink });
            ClientSize = new Size(760, 520); Text = "Register - STAR"; ResumeLayout(false); PerformLayout();
        }
    }
}
