using System.Net.Http;
using System.Threading.Tasks;
using EVA.Models;
using Newtonsoft.Json;

namespace EVA.Services
{
    public class ApodService
    {
        public async Task<ApodDetailDto?> GetApodData(DateTime date)
        {
            string apiKey = "1sE8xPiPS0UEox0lNzCyduo8GLuENVRjvN7q0SMV";
            string dateStr = date.ToString("yyyy-MM-dd");
            string apiUrl = $"https://api.nasa.gov/planetary/apod?api_key={apiKey}&date={dateStr}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    ApodDetailDto? apod = JsonConvert.DeserializeObject<ApodDetailDto>(json);
                    return apod;
                }
                else
                {
                    return null;
                }
            }
        }


        //public async Task<ApodDto?> GetApodData()
        //{
        //    string apiKey = "1sE8xPiPS0UEox0lNzCyduo8GLuENVRjvN7q0SMV";
        //    string apiUrl = $"https://api.nasa.gov/planetary/apod";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage response = await client.GetAsync(apiUrl);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string json = await response.Content.ReadAsStringAsync();
        //            ApodDto? apod = JsonConvert.DeserializeObject<ApodDto>(json);
        //            return apod;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}
    }
}
