using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EVA.Models
{
    public class NasaApodService
    {
        private readonly string baseAddress = "https://api.nasa.gov/planetary/apod/";
        private readonly HttpClient httpClient;
        private readonly string apiKey= "VHwQ19sgMonCG0ajaqNWRPGO3NJoJG1nbKqvnI15";

        public NasaApodService()
        {
            httpClient = new HttpClient();
            
        }
        public async Task<NasaApodResponse> GetApodInfo(string date)
        {
            if (date == null)
            {
                date = DateTime.Today.ToString("yyyy-MM-dd");
            }

            var url = $"{baseAddress}?api_key={apiKey}&date={date}";
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response != null && response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                NasaApodResponse apodResponse = JsonConvert.DeserializeObject<NasaApodResponse>(responseContent);
                return apodResponse;

            }

            throw new Exception($"Failed to retrieve APOD information. Status code: {response.StatusCode}");
          
        }
      
    }
}
