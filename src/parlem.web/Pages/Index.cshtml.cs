using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;

namespace parlem.web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async void OnPostCallAPI()
        {
            string Baseurl = "http://localhost:61955/WeatherForecast";
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiYXBpdXNlciIsImp0aSI6ImU2Y2U3OTY2LWVhYWEtNGY3NS05M2VlLTNiMzQ1ZTNiMTRkOCIsImV4cCI6MTY3NDAwMDI4MywiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo2MTk1NSIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6NDIwMCJ9.wUmpJsLvO5LjCbFVSZG0dhuUkVIfZw2s0hLgz1pzp-g";

            try
            {
                using (var client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage();
                    request.RequestUri = new Uri(Baseurl);
                    request.Method = HttpMethod.Get;
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);                    
                    HttpResponseMessage response = await client.SendAsync(request);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var statusCode = response.StatusCode;
                    if (response.IsSuccessStatusCode)
                    {
                        //API call success, Do your action
                    }

                    else
                    {
                        //API Call Failed, Check Error Details
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
