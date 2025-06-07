using Newtonsoft.Json;

namespace Data.Models
{
    public class ISeason : Base
    {
        [JsonProperty("value")]
        public int value;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("startDate")] // BigInt map sang long trong C#
        public long startDate;

        [JsonProperty("endDate")] // BigInt map sang long trong C#
        public long endDate;
    }
}
