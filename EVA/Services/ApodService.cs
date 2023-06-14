using System.Net.Http;
using System.Threading.Tasks;
using EVA.Models;
using Newtonsoft.Json;

namespace EVA.Services
{
    public class ApodService
    {
        public async Task<ApodDto?> GetApodData(DateTime date)
        {
            string apiKey = "kUkZcMb3f6KCcgOteHWcxijunNwA3gKT4YMRhygi";
            string dateStr = date.ToString("yyyy-MM-dd");
            string apiUrl = $"https://api.nasa.gov/planetary/apod?api_key={apiKey}&date={dateStr}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    ApodDto? apod = JsonConvert.DeserializeObject<ApodDto>(json);
                    return apod;
                }
                else
                {
                    return null;
                }
            }
        }


    }
}
