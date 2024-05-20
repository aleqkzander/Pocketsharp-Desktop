namespace Pocketsharp_Desktop.Utility
{
    internal class MethodUtility
    {
        public static async Task<Pocketsharp.Objects.Response?> Login(HttpClient httpClient, string email, string password, PictureBox imagebox)
        {
            string? jsonResponseObject = await Pocketsharp.Authentication.EmailAndPassword.LoginAsync(httpClient, email, password);
            if (jsonResponseObject == string.Empty) throw new NotImplementedException();

            Pocketsharp.Objects.Response? response = Pocketsharp.Utility.JsonUtility.DeserializeJsonToResponse(jsonResponseObject) ?? throw new NotImplementedException();
            byte[]? byteAvatar = await Pocketsharp.User.DownloadAvatar(httpClient, response, response.Record.Avatar);

            response!.Record.AvatarByte = byteAvatar;
            imagebox.Image = ImageUtility.ByteArrayToImage(response.Record.AvatarByte);

            return response;
        }
    }
}
