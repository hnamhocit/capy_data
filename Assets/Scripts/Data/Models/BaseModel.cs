using System;
using Newtonsoft.Json;

namespace Data.Models
{
    public class Base
    {
        [JsonProperty("id")]
        public int id;

        [JsonProperty("createdAt")]
        public DateTime createdAt;

        [JsonProperty("updatedAt")]
        public DateTime updatedAt;
    }
}
