using Newtonsoft.Json;

namespace Data.Controllers
{
    public class IResponse<T>
    {
        [JsonProperty("code")]
        public int code;

        [JsonProperty("msg")]
        public string msg;

        [JsonProperty("data")]
        public T data;
    }
}
