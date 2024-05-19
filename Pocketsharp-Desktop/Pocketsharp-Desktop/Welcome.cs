using Pocketsharp_Desktop.Objects;
using Pocketsharp_Desktop.Utility;

namespace Pocketsharp_Desktop
{
    public partial class Welcome : Form
    {
        readonly HttpClient _httpClient = new();
        readonly UserData _userData = JsonUtility.ConvertJsonStringToUserData(ConfigUtility.Load()) ?? new();

        public Welcome()
        {
            InitializeComponent();
            TabBar.SelectedIndexChanged += TabBar_OnIndexChanged;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            SetupBaseUrlTextBox.Text = _userData.BaseUrl;

            if (_userData.BaseUrl != string.Empty)
                _httpClient.BaseAddress = new Uri(_userData.BaseUrl);

            SetupUsermailTextBox.Text = _userData.Record.Email;
            SetupPasswordTextBox.Text = _userData.Password;

            if (!string.IsNullOrEmpty(_userData.Record.Username))
                AuthenticationUsernameTextBox.Text = _userData.Record.Username;

            else if (!string.IsNullOrEmpty(_userData.Response.Record.Username))
                AuthenticationUsernameTextBox.Text = _userData.Response.Record.Username;

            if (!string.IsNullOrEmpty(_userData.Record.Name))
                AuthenticationNameTextBox.Text = _userData.Record.Name;

            else if (!string.IsNullOrEmpty(_userData.Response.Record.Name))
                AuthenticationNameTextBox.Text = _userData.Response.Record.Name;

            if (_userData.Record.Avatar.Length != 0)
                AuthenticationAvatarBox.Image = ImageUtility.ByteArrayToImage(_userData.Record.AvatarByte);

            else if (_userData.Response.Record.Avatar.Length != 0)
                AuthenticationAvatarBox.Image = ImageUtility.ByteArrayToImage(_userData.Response.Record.AvatarByte);

            _userData.Validate(StatusTextBox, SetupBaseUrlTextBox, SetupUsermailTextBox, SetupPasswordTextBox);
        }

        private void TabBar_OnIndexChanged(object? sender, EventArgs e)
        {
            if (TabBar.SelectedTab == WelcomeTab) return;

            if (_userData?.Validated == false)
                TabBar.SelectTab(SetupTab);
        }

        private void SetupSaveDataButton_Click(object sender, EventArgs e)
        {
            if (NetworkUtility.BaseAddressIsReachable(SetupBaseUrlTextBox.Text))
            {
                _userData.BaseUrl = SetupBaseUrlTextBox.Text;
                _httpClient.BaseAddress = new Uri(_userData.BaseUrl);

                _userData.Record.Email = SetupUsermailTextBox.Text;
                _userData.Password = SetupPasswordTextBox.Text;
                _userData.Validate(StatusTextBox, SetupBaseUrlTextBox, SetupUsermailTextBox, SetupPasswordTextBox);
                ConfigUtility.Save(JsonUtility.ConvertUserDataToJsonString(_userData));
            }
            else
            {
                MessageBox.Show("Failed saving");
            }
        }

        private void SetupDeleteSavedButton_Click(object sender, EventArgs e)
        {
            ConfigUtility.Delete();
            Application.Exit();
        }

        private async void AuthenticationRegisterUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                _userData.Record.Username = AuthenticationUsernameTextBox.Text;
                _userData.Record.Name = AuthenticationNameTextBox.Text;

                if (AuthenticationAvatarBox.Image != null)
                    _userData.Record.AvatarByte = ImageUtility.ImageToByteArray(AuthenticationAvatarBox.Image);

                string? jsonRecordObject = 
                    await Pocketsharp.Authentication.EmailAndPassword.RegisterAsync(_httpClient, _userData.Record, _userData.Password, _userData.Password);

                // that request was successfull so we overwrite the exsiting data
                if (string.IsNullOrEmpty(jsonRecordObject) == false)
                {
                    // run the login
                    string? jsonResponseObject = await Pocketsharp.Authentication.EmailAndPassword.LoginAsync(_httpClient, _userData.Record.Email, _userData.Password);

                    // that request was successfull so we overwrite the exsiting data
                    if (string.IsNullOrEmpty(jsonResponseObject) == false)
                    {
                        Pocketsharp.Objects.Response? response = Pocketsharp.Utility.JsonUtility.DeserializeJsonToResponse(jsonResponseObject);
                        byte[]? byteAvatar = await Pocketsharp.Authentication.User.DownloadAvatar(_httpClient, response, response.Record.Avatar);

                        if (byteAvatar.Length > 0)
                        {
                            response.Record.AvatarByte = byteAvatar;
                            AuthenticationAvatarBox.Image = ImageUtility.ByteArrayToImage(response.Record.AvatarByte);
                        }

                        _userData.Response = response;

                        if (DialogUtility.ShowYesNoDialog("Do you wan't to overwrite the new record?", "Info"))
                            ConfigUtility.Save(JsonUtility.ConvertUserDataToJsonString(_userData));
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                Clipboard.SetText(exception.ToString());
            }
        }

        private async void AuthenticationLoginUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string? jsonResponseObject = await Pocketsharp.Authentication.EmailAndPassword.LoginAsync(_httpClient, _userData.Record.Email, _userData.Password);

                // that request was successfull so we overwrite the exsiting data
                if (string.IsNullOrEmpty(jsonResponseObject) == false)
                {
                    Pocketsharp.Objects.Response? response = Pocketsharp.Utility.JsonUtility.DeserializeJsonToResponse(jsonResponseObject);
                    byte[]? byteAvatar = await Pocketsharp.Authentication.User.DownloadAvatar(_httpClient, response, response.Record.Avatar);

                    if (byteAvatar.Length > 0)
                    {
                        response.Record.AvatarByte = byteAvatar;
                        AuthenticationAvatarBox.Image = ImageUtility.ByteArrayToImage(response.Record.AvatarByte);
                    }

                    _userData.Response = response;

                    if (DialogUtility.ShowYesNoDialog("Do you wan't to overwrite the new record?", "Info"))
                        ConfigUtility.Save(JsonUtility.ConvertUserDataToJsonString(_userData));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                Clipboard.SetText(exception.ToString());
            }
        }

        private async void AuthenticationUpdateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                _userData.Response.Record.Username = AuthenticationUsernameTextBox.Text;
                _userData.Response.Record.Email = SetupUsermailTextBox.Text;
                _userData.Response.Record.Name = AuthenticationNameTextBox.Text;

                if (AuthenticationAvatarBox.Image != null)
                    _userData.Response.Record.AvatarByte = ImageUtility.ImageToByteArray(AuthenticationAvatarBox.Image);

                string? jsonUpdateResponseObject = 
                    await Pocketsharp.Authentication.User.UpdateAsync(_httpClient, _userData.Response, null, null, null);

                // that request was successfull so we overwrite the exsiting data
                if (string.IsNullOrEmpty(jsonUpdateResponseObject) == false)
                {
                    Pocketsharp.Objects.Response? response = Pocketsharp.Utility.JsonUtility.DeserializeJsonToResponse(jsonUpdateResponseObject);
                    byte[]? byteAvatar = await Pocketsharp.Authentication.User.DownloadAvatar(_httpClient, response, response.Record.Avatar);

                    if (byteAvatar.Length > 0)
                    {
                        response.Record.AvatarByte = byteAvatar;
                        AuthenticationAvatarBox.Image = ImageUtility.ByteArrayToImage(response.Record.AvatarByte);
                    }

                    _userData.Response = response;

                    if (DialogUtility.ShowYesNoDialog("Do you wan't to overwrite the new record?", "Info"))
                        ConfigUtility.Save(JsonUtility.ConvertUserDataToJsonString(_userData));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                Clipboard.SetText(exception.ToString());
            }
        }

        private void AuthenticationDeleteUserButton_Click(object sender, EventArgs e)
        {

        }

        private void AuthenticationUploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    using FileStream fileStream = new(filePath, FileMode.Open, FileAccess.Read);
                    Image image = Image.FromStream(fileStream);

                    AuthenticationAvatarBox.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AuthenticationDeletePictureButton_Click(object sender, EventArgs e)
        {
            AuthenticationAvatarBox.Image = null;
        }
    }
}