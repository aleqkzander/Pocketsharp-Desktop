namespace Pocketsharp_Desktop.Utility
{
    internal class NetworkUtility
    {
        public static bool BaseAddressIsReachable(string baseAddress)
        {
            using var httpClient = new HttpClient();

            try
            {
                httpClient.Timeout = TimeSpan.FromSeconds(10); // Adjust the timeout as needed
                HttpResponseMessage response = httpClient.GetAsync(baseAddress).GetAwaiter().GetResult();
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }
    }
}
