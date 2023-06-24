
namespace HealthBreakCLITest
{
    public class HealthBreakCLI
    {
        static HttpClient httpClient = new HttpClient();

        public void IsValidURl(string url, int quantity)
        {
            List<bool> results = new List<bool>();

            for (int i = 0; i < quantity; i++)
            {
                results.Add(CheckURL(url).Result);
            }

            foreach (bool result in results)
            {
                Console.WriteLine(result);
            }
        }

        private async Task<bool> CheckURL(string url)
        {
            using HttpRequestMessage requeste = new HttpRequestMessage(HttpMethod.Get, url);
            using HttpResponseMessage response = await httpClient.SendAsync(requeste);

            return response.IsSuccessStatusCode;
        }
    }
}
