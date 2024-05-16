using Pocketsharp_Desktop.Objects;
using Pocketsharp_Desktop.Utility;

namespace Pocketsharp_Desktop
{
    public partial class Welcome : Form
    {
        readonly HttpClient _httpClient = new();
        readonly UserData _userData = JsonHandler.ConvertJsonStringToUserData(ConfigUtility.Load()) ?? new();

        public Welcome()
        {
            InitializeComponent();

            TabBar.SelectedIndexChanged += TabBar_OnIndexChanged;
            SetupBaseUrlTextBox.KeyUp += BaseUrlTextBox_OnEnterPressed;
            SetupUsermailTextBox.KeyUp += UsernameTextBox_OnEnterPressed;
            SetupPasswordTextBox.KeyUp += PasswordTextBox_OnEnterPressed;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            SetupBaseUrlTextBox.Text = _userData.BaseUrl;
            SetupUsermailTextBox.Text = _userData.Usermail;
            SetupPasswordTextBox.Text = _userData.Password;
            _userData.Validate(StatusTextBox, SetupBaseUrlTextBox, SetupUsermailTextBox, SetupPasswordTextBox);
        }

        private void TabBar_OnIndexChanged(object? sender, EventArgs e)
        {
            if (TabBar.SelectedTab == WelcomeTab) return;

            if (_userData?.Validated == false)
                TabBar.SelectTab(SetupTab);
        }

        private void BaseUrlTextBox_OnEnterPressed(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(SetupBaseUrlTextBox.Text)) return;

            if (NetworkUtility.BaseAddressIsReachable(SetupBaseUrlTextBox.Text))
            {
                _userData.BaseUrl = SetupBaseUrlTextBox.Text;
                _httpClient.BaseAddress = new Uri(_userData.BaseUrl);
                _userData.Validate(StatusTextBox, SetupBaseUrlTextBox, SetupUsermailTextBox, SetupPasswordTextBox);
            }
        }

        private void UsernameTextBox_OnEnterPressed(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(SetupUsermailTextBox.Text)) return;

            _userData.Usermail = SetupUsermailTextBox.Text;
            _userData.Validate(StatusTextBox, SetupBaseUrlTextBox, SetupUsermailTextBox, SetupPasswordTextBox);
        }

        private void PasswordTextBox_OnEnterPressed(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(SetupPasswordTextBox.Text)) return;

            _userData.Password = SetupPasswordTextBox.Text;
            _userData.Validate(StatusTextBox, SetupBaseUrlTextBox, SetupUsermailTextBox, SetupPasswordTextBox);
        }

        private void SetupDeleteSavedButton_Click(object sender, EventArgs e)
        {
            ConfigUtility.Delete();
            Application.Exit();
        }

        private void AuthenticationRegisterUserButton_Click(object sender, EventArgs e)
        {
        }

        private void AuthenticationLoginUserButton_Click(object sender, EventArgs e)
        {

        }

        private void AuthenticationUpdateUserButton_Click(object sender, EventArgs e)
        {

        }

        private void AuthenticationDeleteUserButton_Click(object sender, EventArgs e)
        {

        }

        private void AuthenticationUploadPictureButton_Click(object sender, EventArgs e)
        {

        }

        private void AuthenticationDeletePictureButton_Click(object sender, EventArgs e)
        {

        }
    }
}