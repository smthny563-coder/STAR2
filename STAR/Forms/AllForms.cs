using System;
using System.Drawing;
using System.Windows.Forms;

namespace STAR.Forms
{
    public class BaseForm : Form
    {
        protected readonly Color Gold = Color.FromArgb(212, 175, 55);
        protected readonly Color Surface = Color.FromArgb(28, 28, 28);

        protected BaseForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(12, 12, 12);
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(760, 520);
        }

        protected void StyleButton(Button button)
        {
            button.BackColor = Gold;
            button.ForeColor = Color.Black;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
        }
    }

    public class SplashForm : BaseForm
    {
        private Timer timer;
        public SplashForm()
        {
            Text = "STAR";
            ClientSize = new Size(520, 340);
            var title = new Label { Text = "STAR", AutoSize = true, ForeColor = Gold, Font = new Font("Segoe UI", 40F, FontStyle.Bold), Location = new Point(190, 95) };
            var subtitle = new Label { Text = "Connect. Share. Shine.", AutoSize = true, ForeColor = Color.Gainsboro, Location = new Point(181, 165) };
            Controls.Add(title);
            Controls.Add(subtitle);
            timer = new Timer { Interval = 900 };
            timer.Tick += delegate { timer.Stop(); Hide(); using (var login = new LoginForm()) login.ShowDialog(); Close(); };
            Shown += delegate { timer.Start(); };
        }
    }

    public class ForgotPasswordForm : BaseForm { public ForgotPasswordForm() { Text = "Forgot Password"; ClientSize = new Size(500, 300); } }
    public class VerificationForm : BaseForm { public VerificationForm() { Text = "Verification"; ClientSize = new Size(500, 300); } }
    public class HomeForm : FeedForm { }
    public class PostDetailsForm : BaseForm { public PostDetailsForm() { Text = "Post Details"; } }
    public class StoriesForm : BaseForm { public StoriesForm() { Text = "Stories"; } }
    public class CreateStoryForm : BaseForm { public CreateStoryForm() { Text = "Create Story"; } }
    public class SearchForm : BaseForm { public SearchForm() { Text = "Search"; } }
    public class EditProfileForm : BaseForm { public EditProfileForm() { Text = "Edit Profile"; } }
    public class FollowersForm : BaseForm { public FollowersForm() { Text = "Followers"; } }
    public class FollowingForm : BaseForm { public FollowingForm() { Text = "Following"; } }
    public class ChatListForm : BaseForm { public ChatListForm() { Text = "Messages"; } }
    public class ChatForm : BaseForm { public ChatForm() { Text = "Chat"; } }
    public class VoiceCallForm : BaseForm { public VoiceCallForm() { Text = "Voice Call"; } }
    public class VideoCallForm : BaseForm { public VideoCallForm() { Text = "Video Call"; } }
    public class NotificationsForm : BaseForm { public NotificationsForm() { Text = "Notifications"; } }
    public class LikesForm : BaseForm { public LikesForm() { Text = "Likes"; } }
    public class SavedPostsForm : BaseForm { public SavedPostsForm() { Text = "Saved Posts"; } }
    public class SettingsForm : BaseForm { public SettingsForm() { Text = "Settings"; } }
    public class PrivacyForm : BaseForm { public PrivacyForm() { Text = "Privacy"; } }
    public class SecurityForm : BaseForm { public SecurityForm() { Text = "Security"; } }
    public class AppearanceForm : BaseForm { public AppearanceForm() { Text = "Appearance"; } }
    public class ActivityForm : BaseForm { public ActivityForm() { Text = "Activity"; } }
    public class AchievementsForm : BaseForm { public AchievementsForm() { Text = "Achievements"; } }
    public class LeaderboardForm : BaseForm { public LeaderboardForm() { Text = "Leaderboard"; } }
    public class AboutForm : BaseForm { public AboutForm() { Text = "About STAR"; } }
}
