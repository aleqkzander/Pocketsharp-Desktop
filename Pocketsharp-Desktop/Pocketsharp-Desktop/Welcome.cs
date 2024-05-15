using Pocketsharp_Desktop.Objects;
using Pocketsharp_Desktop.Utility;

namespace Pocketsharp_Desktop
{
    public partial class Welcome : Form
    {
        UserData _userData = JsonHandler.ConvertJsonStringToUserData(Properties.Settings.Default.JsonUserData);

        public Welcome()
        {
            InitializeComponent();

            TabBar.SelectedIndexChanged += TabBar_OnIndexChanged;
            BaseUrlTextBox.KeyUp += BaseUrlTextBox_OnEnterPressed;
            UsernameTextBox.KeyUp += UsernameTextBox_OnEnterPressed;
            PasswordTextBox.KeyUp += PasswordTextBox_OnEnterPressed;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            _userData.Validate(StatusTextBox, BaseUrlTextBox, UsernameTextBox, PasswordTextBox);
        }

        private void TabBar_OnIndexChanged(object? sender, EventArgs e)
        {
            // allow the user to enter the welcome tab at anytime
            if (TabBar.SelectedTab == WelcomeTab) return;

            // check if the user has provided all required information otherwise redirect to the setup tab
            if (_userData?.Validated == false) 
                TabBar.SelectTab(SetupTab);
        }

        private void BaseUrlTextBox_OnEnterPressed(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(BaseUrlTextBox.Text)) return;
            _userData.BaseUrl = BaseUrlTextBox.Text;

            _userData.Validate(StatusTextBox, BaseUrlTextBox, UsernameTextBox, PasswordTextBox);
        }

        private void UsernameTextBox_OnEnterPressed(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(UsernameTextBox.Text)) return;
            _userData.Username = UsernameTextBox.Text;

            _userData.Validate(StatusTextBox, BaseUrlTextBox, UsernameTextBox, PasswordTextBox);
        }

        private void PasswordTextBox_OnEnterPressed(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(PasswordTextBox.Text)) return;
            _userData.Password = PasswordTextBox.Text;

            _userData.Validate(StatusTextBox, BaseUrlTextBox, UsernameTextBox, PasswordTextBox);
        }
    }
}