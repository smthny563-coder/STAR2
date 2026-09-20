using System.Drawing;
using System.Windows.Forms;

namespace STAR.Forms
{
    partial class LoginForm
    {
        private Label logoLabel;
        private Label headingLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private LinkLabel registerLink;
        private LinkLabel forgotLink;

        private void InitializeComponent()
        {
            logoLabel = new Label(); headingLabel = new Label(); usernameLabel = new Label(); passwordLabel = new Label();
            usernameTextBox = new TextBox(); passwordTextBox = new TextBox(); loginButton = new Button(); registerLink = new LinkLabel(); forgotLink = new LinkLabel();
            SuspendLayout();
            logoLabel.AutoSize = true; logoLabel.Font = new Font("Segoe UI", 34F, FontStyle.Bold); logoLabel.ForeColor = Gold; logoLabel.Location = new Point(340, 42); logoLabel.Text = "STAR";
            headingLabel.AutoSize = true; headingLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold); headingLabel.Location = new Point(290, 112); headingLabel.Text = "Welcome back";
            usernameLabel.AutoSize = true; usernameLabel.Location = new Point(210, 175); usernameLabel.Text = "Username or email";
            usernameTextBox.Location = new Point(210, 200); usernameTextBox.Size = new Size(340, 25);
            passwordLabel.AutoSize = true; passwordLabel.Location = new Point(210, 245); passwordLabel.Text = "Password";
            passwordTextBox.Location = new Point(210, 270); passwordTextBox.Size = new Size(340, 25); passwordTextBox.UseSystemPasswordChar = true;
            loginButton.Location = new Point(210, 325); loginButton.Size = new Size(340, 42); loginButton.Text = "SIGN IN"; StyleButton(loginButton); loginButton.Click += loginButton_Click;
            forgotLink.AutoSize = true; forgotLink.LinkColor = Gold; forgotLink.Location = new Point(430, 382); forgotLink.Text = "Forgot password?"; forgotLink.LinkClicked += forgotLink_LinkClicked;
            registerLink.AutoSize = true; registerLink.LinkColor = Gold; registerLink.Location = new Point(290, 425); registerLink.Text = "Create a new account"; registerLink.LinkClicked += registerLink_LinkClicked;
            Controls.AddRange(new Control[] { logoLabel, headingLabel, usernameLabel, usernameTextBox, passwordLabel, passwordTextBox, loginButton, forgotLink, registerLink });
            AcceptButton = loginButton; ClientSize = new Size(760, 520); Text = "Login - STAR"; ResumeLayout(false); PerformLayout();
        }
    }
}
