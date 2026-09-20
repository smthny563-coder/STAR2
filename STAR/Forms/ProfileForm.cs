using System;
using System.Windows.Forms;

namespace STAR.Forms
{
    public partial class ProfileForm : BaseForm
    {
        public ProfileForm() { InitializeComponent(); }
        private void editButton_Click(object sender, EventArgs e) { MessageBox.Show("Profile editing is ready for your account data.", "Edit profile", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        private void closeButton_Click(object sender, EventArgs e) { Close(); }
    }
}
