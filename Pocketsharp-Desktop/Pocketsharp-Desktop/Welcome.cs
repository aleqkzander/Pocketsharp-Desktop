using Pocketsharp_Desktop.Objects;
using Pocketsharp_Desktop.Utility;

namespace Pocketsharp_Desktop
{
    public partial class Welcome : Form
    {
        UserData? _userData;

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
            _userData = JsonHandler.ConvertJsonStringToUserData(Properties.Settings.Default.JsonUserData);

            if (string.IsNullOrEmpty(_userData?.BaseUrl))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a base url in the setup tab");
                TextBoxUtility.SetupTextBox(BaseUrlTextBox, "Enter your base url", _userData?.BaseUrl);
            }

            if (string.IsNullOrEmpty(_userData?.Username))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a username in the setup tab");
                TextBoxUtility.SetupTextBox(UsernameTextBox, "Enter your username", _userData?.Username);
            }

            if (string.IsNullOrEmpty(_userData?.Password))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a password in the setup tab");
                TextBoxUtility.SetupTextBox(PasswordTextBox, "Enter your password", _userData?.Password);
            }

            if (string.IsNullOrEmpty(_userData?.JsonAuthRecord))
            {
                TextBoxUtility.AddINFOEntry(StatusTextBox, "No auth record found");
            }

            if (string.IsNullOrEmpty(_userData?.JsonAuthResponse))
            {
                TextBoxUtility.AddINFOEntry(StatusTextBox, "No auth response found");
            }
        }
    }
}