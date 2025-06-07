using Newtonsoft.Json;
namespace Data.Models
{

    public enum Status
    {
        Upcoming,
        Ongoing,
        Completed,
        Cancelled
    }

    public class IEvent : Base
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("description")]
        public string description;

        [JsonProperty("bannerURL")] // Tên JSON có thể là "bannerUrl" (camelCase)
        public string bannerURL;

        [JsonProperty("progress")]
        public int progress;

        [JsonProperty("startDate")]
        public long startDate; // BigInt thường được map sang long trong C#

        [JsonProperty("endDate")]
        public long endDate; // BigInt thường được map sang long trong C#

        [JsonProperty("status")]
        public Status status;
    }
}
