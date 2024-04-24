using Pocketsharp_Desktop.Objects;
using System.Text.Json;

namespace Pocketsharp_Desktop.Utility
{
    internal class JsonHandler
    {
        public static string? ConvertUserDataToJsonString(UserData userdata)
        {
            if (userdata == null) return null;
            return JsonSerializer.Serialize(userdata);
        }

        public static UserData? ConvertJsonStringToUserData(string jsonuserdata)
        {
            if (string.IsNullOrEmpty(jsonuserdata)) return null;
            return JsonSerializer.Deserialize<UserData>(jsonuserdata);
        }
    }
}