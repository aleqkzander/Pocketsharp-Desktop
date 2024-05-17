using Pocketsharp_Desktop.Objects;
using System.Text.Json;

namespace Pocketsharp_Desktop.Utility
{
    internal class JsonUtility
    {
        public static string ConvertUserDataToJsonString(UserData userdata)
        {
            try { return JsonSerializer.Serialize(userdata); }
            catch { return string.Empty; }
        }

        public static UserData ConvertJsonStringToUserData(string jsonuserdata)
        {
            try { return JsonSerializer.Deserialize<UserData>(jsonuserdata)!; }
            catch { return new(); }
        }
    }
}