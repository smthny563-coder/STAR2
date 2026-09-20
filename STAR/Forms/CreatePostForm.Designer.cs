using System.Drawing;
using System.Windows.Forms;

namespace STAR.Forms
{
    partial class CreatePostForm
    {
        private Label headingLabel, promptLabel, imageLabel; private TextBox contentTextBox; private Button publishButton, cancelButton, imageButton;
        private void InitializeComponent()
        {
            headingLabel = new Label(); promptLabel = new Label(); imageLabel = new Label(); contentTextBox = new TextBox(); publishButton = new Button(); cancelButton = new Button(); imageButton = new Button(); SuspendLayout();
            headingLabel.AutoSize = true; headingLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold); headingLabel.ForeColor = Gold; headingLabel.Location = new Point(35, 30); headingLabel.Text = "Create a post";
            promptLabel.AutoSize = true; promptLabel.Location = new Point(38, 95); promptLabel.Text = "What would you like to share?";
            contentTextBox.Location = new Point(38, 125); contentTextBox.Multiline = true; contentTextBox.ScrollBars = ScrollBars.Vertical; contentTextBox.Size = new Size(684, 190); contentTextBox.Font = new Font("Segoe UI", 12F);
            imageButton.Location = new Point(38, 340); imageButton.Size = new Size(125, 35); imageButton.Text = "Add image"; imageButton.Click += imageButton_Click;
            imageLabel.AutoSize = true; imageLabel.ForeColor = Color.Gray; imageLabel.Location = new Point(180, 350); imageLabel.Text = "No image selected";
            cancelButton.Location = new Point(482, 410); cancelButton.Size = new Size(110, 38); cancelButton.Text = "Cancel"; cancelButton.Click += cancelButton_Click;
            publishButton.Location = new Point(612, 410); publishButton.Size = new Size(110, 38); publishButton.Text = "Publish"; StyleButton(publishButton); publishButton.Click += publishButton_Click;
            Controls.AddRange(new Control[] { headingLabel, promptLabel, contentTextBox, imageButton, imageLabel, cancelButton, publishButton }); AcceptButton = publishButton; CancelButton = cancelButton; ClientSize = new Size(760, 490); Text = "Create Post - STAR"; ResumeLayout(false); PerformLayout();
        }
    }
}
