using Newtonsoft.Json;

namespace Data.Models
{
    [System.Serializable]
    public class SocketPayload<T>
    {
        public string cmd;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T @params;
    }
}

















