using System;
using System.IO;
using System.Windows.Forms;

namespace STAR.Forms
{
    public partial class CreatePostForm : BaseForm
    {
        public CreatePostForm() { InitializeComponent(); }
        private void publishButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contentTextBox.Text)) { MessageBox.Show("Write something before publishing.", "Create post", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Your post has been published.", "Create post", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close();
        }
        private void cancelButton_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
        private void imageButton_Click(object sender, EventArgs e) { using (var dialog = new OpenFileDialog { Filter = "Images|*.png;*.jpg;*.jpeg;*.gif|All files|*.*" }) if (dialog.ShowDialog(this) == DialogResult.OK) imageLabel.Text = Path.GetFileName(dialog.FileName); }
    }
}
