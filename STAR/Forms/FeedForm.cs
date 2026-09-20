using System;
using System.Windows.Forms;

namespace STAR.Forms
{
    public partial class FeedForm : BaseForm
    {
        public FeedForm() { InitializeComponent(); }
        private void createPostButton_Click(object sender, EventArgs e) { using (var form = new CreatePostForm()) if (form.ShowDialog(this) == DialogResult.OK) LoadPosts(); }
        private void profileButton_Click(object sender, EventArgs e) { using (var form = new ProfileForm()) form.ShowDialog(this); }
        private void refreshButton_Click(object sender, EventArgs e) { LoadPosts(); }
        private void LoadPosts() { postsPanel.Controls.Clear(); AddPost("Maya Johnson", "A bright new day in the city ✨", "2 minutes ago", 128); AddPost("Alex Rivera", "Working on something exciting. Stay tuned!", "35 minutes ago", 76); AddPost("STAR Community", "Welcome to STAR — connect, share and shine.", "Yesterday", 214); }
        private void AddPost(string author, string body, string time, int likes)
        {
            var card = new Panel { BackColor = Surface, Width = postsPanel.Width - 25, Height = 130, Margin = new Padding(0, 0, 0, 12), Padding = new Padding(18) };
            card.Controls.Add(new Label { Text = author, ForeColor = Gold, Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold), Location = new System.Drawing.Point(15, 12), AutoSize = true });
            card.Controls.Add(new Label { Text = time, ForeColor = System.Drawing.Color.Gray, Location = new System.Drawing.Point(15, 38), AutoSize = true });
            card.Controls.Add(new Label { Text = body, Location = new System.Drawing.Point(15, 67), AutoSize = true });
            card.Controls.Add(new Label { Text = "♥  " + likes + " likes", ForeColor = Gold, Location = new System.Drawing.Point(15, 96), AutoSize = true }); postsPanel.Controls.Add(card);
        }
    }
}
