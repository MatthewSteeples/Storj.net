using Newtonsoft.Json;
using System;

namespace Storj.net.Models
{
    public class NewUserResponse
    {
        [JsonProperty("email")]
        public String Email { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("activated")]
        public Boolean Activated { get; set; }
    }
}
