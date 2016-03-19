using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Storj.net.Models
{
    //storage (number, optional): Amount of storage space in GB ,
    //transfer (number, optional): Amount of transfer in GB ,
    //status (string, optional): State of the bucket ,
    //pubkeys (Array[string], optional),
    //user (string, optional): User account to which the bucket belongs ,
    //name (string, optional): Name of the bucket ,
    //created (string, optional): The date and time the bucket was created ,
    //id (string, optional): Unique ID for the bucket
    public class Bucket
    {
        [JsonProperty("storage")]
        public int Storage { get; set; }

    }
}
