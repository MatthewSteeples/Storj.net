using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Storj.net.Models
{
    //{
    //  "storage": 10,
    //  "transfer": 30,
    //  "status": "Active",
    //  "pubkeys": [
    //    "031a259ee122414f57a63bbd6887ee17960e9106b0adcf89a298cdad2108adf4d9"
    //  ],
    //  "user": "gordon@storj.io",
    //  "name": "New Bucket",
    //  "created": "2016-03-04T17:01:02.629Z",
    //  "id": "507f1f77bcf86cd799439011"
    //}
    public class Bucket
    {
        [JsonProperty("storage")]
        public int Storage { get; set; }

        [JsonProperty("transfer")]
        public int Transfer { get; set; }

        [JsonProperty("status")]
        public String Status { get; set; }

        [JsonProperty("pubkeys")]
        public ICollection<String> PubKeys { get; set; }

        [JsonProperty("user")]
        public String User { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("id")]
        public String Id { get; set; }
    }
}