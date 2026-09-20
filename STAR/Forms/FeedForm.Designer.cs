using System.Drawing;
using System.Windows.Forms;

namespace STAR.Forms
{
    partial class FeedForm
    {
        private Panel headerPanel, postsPanel; private Label logoLabel, titleLabel; private Button createPostButton, profileButton, refreshButton;
        private void InitializeComponent()
        {
            headerPanel = new Panel(); postsPanel = new Panel(); logoLabel = new Label(); titleLabel = new Label(); createPostButton = new Button(); profileButton = new Button(); refreshButton = new Button(); SuspendLayout();
            headerPanel.BackColor = Surface; headerPanel.Dock = DockStyle.Top; headerPanel.Height = 78;
            logoLabel.AutoSize = true; logoLabel.Font = new Font("Segoe UI", 23F, FontStyle.Bold); logoLabel.ForeColor = Gold; logoLabel.Location = new Point(24, 17); logoLabel.Text = "STAR";
            titleLabel.AutoSize = true; titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold); titleLabel.Location = new Point(150, 27); titleLabel.Text = "Your feed";
            createPostButton.Location = new Point(450, 20); createPostButton.Size = new Size(130, 38); createPostButton.Text = "+  Create post"; StyleButton(createPostButton); createPostButton.Click += createPostButton_Click;
            refreshButton.Location = new Point(590, 20); refreshButton.Size = new Size(80, 38); refreshButton.Text = "Refresh"; refreshButton.Click += refreshButton_Click;
            profileButton.Location = new Point(680, 20); profileButton.Size = new Size(80, 38); profileButton.Text = "Profile"; profileButton.Click += profileButton_Click;
            headerPanel.Controls.AddRange(new Control[] { logoLabel, titleLabel, createPostButton, refreshButton, profileButton });
            postsPanel.AutoScroll = true; postsPanel.Dock = DockStyle.Fill; postsPanel.Padding = new Padding(45, 25, 25, 25); postsPanel.Resize += delegate { LoadPosts(); };
            Controls.Add(postsPanel); Controls.Add(headerPanel); ClientSize = new Size(800, 600); Text = "Feed - STAR"; Load += delegate { LoadPosts(); }; ResumeLayout(false);
        }
    }
}
