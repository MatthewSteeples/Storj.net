using Newtonsoft.Json;
using System;

namespace Storj.net.Models
{
    public class NewUserRequest
    {
        [JsonProperty("email")]
        public String Email { get; set; }

        [JsonProperty("password")]
        public String Password { get; set; }

        public NewUserRequest()
        {
        }
    }
}
