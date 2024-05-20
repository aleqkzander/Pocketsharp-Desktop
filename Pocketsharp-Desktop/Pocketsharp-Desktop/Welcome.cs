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

            SetupUsermailTextBox.Text = _userData.Response.Record.Email;
            SetupPasswordTextBox.Text = _userData.Password;

            if (!string.IsNullOrEmpty(_userData.Response.Record.Username))
                AuthenticationUsernameTextBox.Text = _userData.Response.Record.Username;

            if (!string.IsNullOrEmpty(_userData.Response.Record.Name))
                AuthenticationNameTextBox.Text = _userData.Response.Record.Name;

            if (_userData.Response.Record.AvatarFilename != string.Empty)
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

                _userData.Response.Record.Email = SetupUsermailTextBox.Text;
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
                Pocketsharp.Objects.Record userRecord = new()
                {
                    Email = _userData.Response.Record.Email,
                    Username = AuthenticationUsernameTextBox.Text,
                    Name = AuthenticationNameTextBox.Text
                };

                if (AuthenticationAvatarBox.Image != null)
                    userRecord.AvatarByte = ImageUtility.ImageToByteArray(AuthenticationAvatarBox.Image);

                string? jsonRecordObject = await Pocketsharp.Authentication.EmailAndPassword.RegisterAsync(_httpClient, userRecord, _userData.Password, _userData.Password);

                if (string.IsNullOrEmpty(jsonRecordObject) == false)
                {
                    Pocketsharp.Objects.Response? loginResponse = await MethodUtility.Login(_httpClient, userRecord.Email, _userData.Password, AuthenticationAvatarBox)
                        ?? throw new NotImplementedException();

                    _userData.Response = loginResponse;

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

        private async void AuthenticationLoginUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pocketsharp.Objects.Response? loginResponse = await MethodUtility.Login(_httpClient, _userData.Response.Record.Email, _userData.Password, AuthenticationAvatarBox)
                    ?? throw new NotImplementedException();

                _userData.Response = loginResponse;

                if (DialogUtility.ShowYesNoDialog("Do you wan't to overwrite the new record?", "Info"))
                    ConfigUtility.Save(JsonUtility.ConvertUserDataToJsonString(_userData));
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
                // update information
                _userData.Response.Record.Username = AuthenticationUsernameTextBox.Text;
                _userData.Response.Record.Email = SetupUsermailTextBox.Text;
                _userData.Response.Record.Name = AuthenticationNameTextBox.Text;

                if (AuthenticationAvatarBox.Image != null)
                    _userData.Response.Record.AvatarByte = ImageUtility.ImageToByteArray(AuthenticationAvatarBox.Image);

                string? jsonUpdateResponseObject =
                    await Pocketsharp.User.UpdateAsync(_httpClient, _userData.Response, null, null, null);

                // that request was successfull so we overwrite the exsiting data
                if (string.IsNullOrEmpty(jsonUpdateResponseObject) == false)
                {
                    Pocketsharp.Objects.Response? loginResponse = await MethodUtility.Login(_httpClient, _userData.Response.Record.Email, _userData.Password, AuthenticationAvatarBox)
                        ?? throw new NotImplementedException();

                    _userData.Response = loginResponse;

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

        private async void AuthenticationDeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool deletationRequest = await Pocketsharp.User.DeleteAsync(_httpClient, _userData.Response.Record.Id, _userData.Response.Token);

                if (deletationRequest == true)
                {
                    MessageBox.Show("Your data was deleted successfully. Your savefile will be deleted and the application will be shutdown.");
                    ConfigUtility.Delete();
                    Application.Exit();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                Clipboard.SetText(exception.ToString());
            }
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

        private void CollectionCreateEntryButton_Click(object sender, EventArgs e)
        {

        }

        private void CollectionGetAllEntrysButton_Click(object sender, EventArgs e)
        {

        }

        private void CollectionGetSingleEntryButton_Click(object sender, EventArgs e)
        {

        }
    }
}