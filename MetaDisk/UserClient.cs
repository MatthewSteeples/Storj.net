using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MetaDisk
{
    public class UserClient : BaseClient, IDisposable
    {
        private readonly String _apiUrl;
        public UserClient()
        {
            _httpClient = new System.Net.Http.HttpClient();
            _apiUrl = "https://api.metadisk.org/users";
        }

        public async Task<Storj.net.Models.NewUserResponse> AddAsync(Storj.net.Models.NewUserRequest user)
        {
            String requestJson = JsonConvert.SerializeObject(user);
            StringContent requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await _httpClient.PostAsync(String.Format("{0}", _apiUrl), requestContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                String responseContent = await responseMessage.Content.ReadAsStringAsync();
                Storj.net.Models.NewUserResponse response = JsonConvert.DeserializeObject<Storj.net.Models.NewUserResponse>(responseContent);

                return response;
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
