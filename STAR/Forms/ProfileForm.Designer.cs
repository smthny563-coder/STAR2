using System.Drawing;
using System.Windows.Forms;

namespace STAR.Forms
{
    partial class ProfileForm
    {
        private Panel profileHeader; private Label avatarLabel, nameLabel, handleLabel, bioLabel, statsLabel, postsTitle; private Button editButton, closeButton;
        private void InitializeComponent()
        {
            profileHeader = new Panel(); avatarLabel = new Label(); nameLabel = new Label(); handleLabel = new Label(); bioLabel = new Label(); statsLabel = new Label(); postsTitle = new Label(); editButton = new Button(); closeButton = new Button(); SuspendLayout();
            profileHeader.BackColor = Surface; profileHeader.Location = new Point(30, 25); profileHeader.Size = new Size(700, 210);
            avatarLabel.BackColor = Gold; avatarLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold); avatarLabel.ForeColor = Color.Black; avatarLabel.Text = "SJ"; avatarLabel.TextAlign = ContentAlignment.MiddleCenter; avatarLabel.Location = new Point(25, 28); avatarLabel.Size = new Size(120, 120);
            nameLabel.AutoSize = true; nameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold); nameLabel.Location = new Point(175, 30); nameLabel.Text = "Sam Johnson";
            handleLabel.AutoSize = true; handleLabel.ForeColor = Gold; handleLabel.Location = new Point(178, 70); handleLabel.Text = "@samjohnson";
            bioLabel.AutoSize = true; bioLabel.Location = new Point(178, 105); bioLabel.Text = "Building community and sharing the moments that matter.";
            statsLabel.AutoSize = true; statsLabel.ForeColor = Color.Gainsboro; statsLabel.Location = new Point(178, 145); statsLabel.Text = "24 posts     1.2K followers     386 following";
            editButton.Location = new Point(540, 30); editButton.Size = new Size(130, 36); editButton.Text = "Edit profile"; StyleButton(editButton); editButton.Click += editButton_Click;
            profileHeader.Controls.AddRange(new Control[] { avatarLabel, nameLabel, handleLabel, bioLabel, statsLabel, editButton });
            postsTitle.AutoSize = true; postsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold); postsTitle.Location = new Point(30, 265); postsTitle.Text = "Recent posts";
            closeButton.Location = new Point(620, 430); closeButton.Size = new Size(110, 36); closeButton.Text = "Close"; closeButton.Click += closeButton_Click;
            Controls.AddRange(new Control[] { profileHeader, postsTitle, closeButton }); ClientSize = new Size(760, 500); Text = "Profile - STAR"; ResumeLayout(false); PerformLayout();
        }
    }
}
