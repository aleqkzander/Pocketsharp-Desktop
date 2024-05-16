using Pocketsharp_Desktop.Utility;

namespace Pocketsharp_Desktop.Objects
{
    internal class UserData
    {
        public string? BaseUrl { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? JsonAuthRecord { get; set; }
        public string? JsonAuthResponse { get; set; }
        public bool Validated { get; set; }

        public UserData() { }

        public void Validate(RichTextBox StatusTextBox, TextBox BaseUrlTextBox, TextBox UsernameTextBox, TextBox PasswordTextBox)
        {
            StatusTextBox.Clear();

            if (string.IsNullOrEmpty(BaseUrl))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a base url in the setup tab");
                TextBoxUtility.SetupTextBox(BaseUrlTextBox, "Enter your base url", BaseUrl);
            }

            if (string.IsNullOrEmpty(Username))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a username in the setup tab");
                TextBoxUtility.SetupTextBox(UsernameTextBox, "Enter your username", Username);
            }

            if (string.IsNullOrEmpty(Password))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a password in the setup tab");
                TextBoxUtility.SetupTextBox(PasswordTextBox, "Enter your password", Password);
                return;
            }

            // from this point on all required information was provided
            Validated = true;

            if (string.IsNullOrEmpty(JsonAuthRecord))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Register a new user");
                TextBoxUtility.AddINFOEntry(StatusTextBox, "No auth record found");
                return;
            }

            if (string.IsNullOrEmpty(JsonAuthResponse))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Login is required");
                TextBoxUtility.AddINFOEntry(StatusTextBox, "No auth response found");
                return;
            }
        }
    }
}