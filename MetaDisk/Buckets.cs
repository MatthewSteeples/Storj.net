using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDisk
{
    public class Buckets : BaseClient, IDisposable
    {
        public Buckets()
        {
            _httpClient = new System.Net.Http.HttpClient();
        }

        public async Task<String> Put(BE.Models.RedeemRequest request)
        {
            String requestJson = JsonConvert.SerializeObject(request);
            StringContent requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            Task<HttpResponseMessage> responseTask = _httpClient.PostAsync(String.Format("{0}redeem", _apiUrl), requestContent);
            HttpResponseMessage responseMessage = await responseTask;

            if (responseMessage.IsSuccessStatusCode)
            {
                String responseContent = await responseMessage.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
