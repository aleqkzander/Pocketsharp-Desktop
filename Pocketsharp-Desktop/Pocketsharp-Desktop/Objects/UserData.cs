using Pocketsharp_Desktop.Utility;

namespace Pocketsharp_Desktop.Objects
{
    internal class UserData
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string Usermail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string JsonAuthRecord { get; set; } = string.Empty;
        public string JsonAuthResponse { get; set; } = string.Empty;
        public bool Validated { get; set; } = false;

        public void Validate(RichTextBox StatusTextBox, TextBox BaseUrlTextBox, TextBox UsermailTextBox, TextBox PasswordTextBox)
        {
            StatusTextBox.Clear();

            if (string.IsNullOrEmpty(BaseUrl))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a base url in the setup tab");
                TextBoxUtility.SetupTextBox(BaseUrlTextBox, "Enter your base url", BaseUrl);
            }

            if (string.IsNullOrEmpty(Usermail))
            {
                TextBoxUtility.AddTODOEntry(StatusTextBox, "Setup a usermail in the setup tab");
                TextBoxUtility.SetupTextBox(UsermailTextBox, "Enter your mail", Usermail);
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