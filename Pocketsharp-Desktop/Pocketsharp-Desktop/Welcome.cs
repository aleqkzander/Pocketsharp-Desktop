using Pocketsharp_Desktop.Utility;

namespace Pocketsharp_Desktop
{
    public partial class Welcome : Form
    {
        string? _baseurl;
        string? _username;
        string? _password;
        string? _jsonAuthRecord;
        string? _jsonAuthResponse;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            LoadAndAssignSavedValues();
        }

        private void LoadAndAssignSavedValues()
        {
            _baseurl = Properties.Settings.Default.BaseURL;
            _username = Properties.Settings.Default.Username;
            _password = Properties.Settings.Default.Password;
            _jsonAuthRecord = Properties.Settings.Default.JsonAuthRecord;
            _jsonAuthResponse = Properties.Settings.Default.JsonAuthResponse;

            if (string.IsNullOrEmpty(_baseurl))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a base url in the setup tab");
                TextBoxUtility.SetupTextBox(BaseUrlTextBox, "Enter your base url", _baseurl);
            }

            if (string.IsNullOrEmpty(_username))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a username in the setup tab");
                TextBoxUtility.SetupTextBox(UsernameTextBox, "Enter your username", _username);
            }

            if (string.IsNullOrEmpty(_password))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a password in the setup tab");
                TextBoxUtility.SetupTextBox(PasswordTextBox, "Enter your password", _password);
            }

            if (string.IsNullOrEmpty(_jsonAuthRecord))
            {
                TextBoxUtility.AddINFOEntry(StatusTextBox, "No auth record found");
            }

            if (string.IsNullOrEmpty(_jsonAuthResponse))
            {
                TextBoxUtility.AddINFOEntry(StatusTextBox, "No auth response found");
            }
        }
    }
}