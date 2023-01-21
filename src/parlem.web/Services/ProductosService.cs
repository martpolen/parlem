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
    public class ProductosService
    {

        public async Task<List<ProductViewModel>> GetProductsByCustomerId(int idCustomer)
        {
            string Baseurl = Config.GetConfig("ApiHost") + Config.GetConfig("ProductsCustomerEndpoint");
            string token = Config.GetConfig("tokenApi");

            try
            {
                using (var client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage();
                    request.RequestUri = new Uri(Baseurl + "/" + idCustomer);
                    request.Method = HttpMethod.Get;
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    HttpResponseMessage response = await client.SendAsync(request);
                    var statusCode = response.StatusCode;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<ProductViewModel>>(responseString);
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

        public async Task<ProductViewModel> GetProductsDetails(int id)
        {
            string Baseurl = Config.GetConfig("ApiHost") + Config.GetConfig("ProductsEndpoint");
            string token = Config.GetConfig("tokenApi");

            try
            {
                using (var client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage();
                    request.RequestUri = new Uri(Baseurl + "/" + id);
                    request.Method = HttpMethod.Get;
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    HttpResponseMessage response = await client.SendAsync(request);
                    var statusCode = response.StatusCode;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<ProductViewModel>(responseString);
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
