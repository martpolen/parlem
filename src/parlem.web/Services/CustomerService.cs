using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using parlem.common.Config;
using parlem.web.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace parlem.web.Services
{
    public class CustomerService
    {

        public async Task<List<CustomerModel>> GetAllCustomers()
        {
            string Baseurl = Config.GetConfig("ApiHost") + Config.GetConfig("CustomersEndpoint");
            string token = Config.GetConfig("tokenApi");

            try
            {
                using (var client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage();
                    request.RequestUri = new Uri(Baseurl);
                    request.Method = HttpMethod.Get;
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    HttpResponseMessage response = await client.SendAsync(request);
                    var statusCode = response.StatusCode;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<CustomerModel>>(responseString);
                    }

                    else
                    {
                        //API Call Failed, Check Error Details
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
