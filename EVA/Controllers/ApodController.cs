using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using NasaApodExample.Models;

namespace NasaApodExample.Controllers
{
    public class ApodController : Controller
    {
        public async Task<ApodModel> GetApodData()
        {
            string apiKey = "1sE8xPiPS0UEox0lNzCyduo8GLuENVRjvN7q0SMV";
            string apiUrl = $"https://api.nasa.gov/planetary/apod?api_key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    ApodModel apod = JsonConvert.DeserializeObject<ApodModel>(json);
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
